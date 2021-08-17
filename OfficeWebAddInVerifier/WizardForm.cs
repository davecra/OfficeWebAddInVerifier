using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeWebAddInVerifier
{
    public partial class FormWizard : Form
    {
        private WizardController MobjWizard = null;
        public FormWizard()
        {
            InitializeComponent();
        }
        /// <summary>
        /// User clicked the select button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Manifest Files (*.xml) | *.xml";
            openFileDialog.Title = Application.ProductName;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxManifest.Text = openFileDialog.FileName;
                MobjWizard.AllowNextButton();
            }
        }

        private void FormWizard_Load(object sender, EventArgs e)
        {
            MobjWizard = new WizardController(new WizardButtons() { BackButton = buttonBack, CancelButton = buttonCancel, NextButton = buttonNext },
                                              new[] { panel1, panel2, panel3, panel4, panel5 });
            MobjWizard.Closed += (o, ev) => { this.Close(); };
            MobjWizard.Finished += (o, ev) =>
            {
                // load up the verifier and then check
                ManifestVerifier LobjVerifier = new ManifestVerifier(textBoxManifest.Text);
                LogForm LobjLog = new LogForm();
                LobjLog.FormClosed += (oj, ej) => { this.Close(); };
                LobjLog.Visible = true;
                this.Visible = false;
                LobjVerifier.LogEvent += (ob, PobjEvent) => 
                {
                    LobjLog.LogItem(PobjEvent.Message, PobjEvent.Success);
                    LobjLog.Refresh();
                    Application.DoEvents();
                };
                LobjVerifier.NotificationEvent += (ob, PobjEvent) => 
                {
                    LobjLog.Notification(PobjEvent.Message);
                    LobjLog.Refresh();
                    Application.DoEvents();
                };
                if (!LobjVerifier.Check())
                {
                    // we failed for some reason
                    MessageBox.Show("The verification of the manifest failed.\n\n" +
                                    LobjVerifier.FailDescription,
                                    Application.ProductName,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // we were successful
                    MessageBox.Show("The manifest verification has completed.",
                                    Application.ProductName,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            // allow next buitton
            MobjWizard.AllowNextButton();
        }

        private void radioButtonFileList_CheckedChanged(object sender, EventArgs e)
        {
            buttonOpen.Visible = true;
            buttonOpen.Enabled = true;
            if (String.IsNullOrEmpty(textBoxLocation.Text))
            {
                groupBoxFileList.Visible = false;
            }
            else
            {
                groupBoxFileList.Visible = true;
            }
        }

        private void radioButtonScanFolder_CheckedChanged(object sender, EventArgs e)
        {
            buttonOpen.Visible = true;
            buttonOpen.Enabled = true;
            if (String.IsNullOrEmpty(textBoxLocation.Text))
            {
                groupBoxFileList.Visible = false;
            }
            else
            {
                groupBoxFileList.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            buttonOpen.Visible = false;
            groupBoxFileList.Visible = false;
            MobjWizard.AllowNextButton();
        }

        private void panel4_VisibleChanged(object sender, EventArgs e)
        {
            if(MobjWizard != null) MobjWizard.AllowNextButton();
        }

        private void panel5_VisibleChanged(object sender, EventArgs e)
        {
            if(MobjWizard != null) MobjWizard.AllowNextButton();
        }

        private void SetFilePanel(bool PbolEnabled)
        {
            buttonOpen.Enabled = PbolEnabled;
            buttonBack.Enabled = PbolEnabled;
            radioButtonFileList.Enabled = PbolEnabled;
            radioButtonScanFolder.Enabled = PbolEnabled;
            radioButton1.Enabled = PbolEnabled;
            buttonSave.Enabled = PbolEnabled;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if(radioButtonFileList.Checked)
            {
                openFileDialog.Filter = "Text File - List (*.txt) | *.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxLocation.Text = openFileDialog.FileName;
                    this.Refresh();
                    SetFilePanel(false);
                    // get the files
                    StreamReader LobjReader = new StreamReader(textBoxLocation.Text);
                    string[] LstrList = LobjReader.ReadToEnd().Split('\n');
                    LobjReader.Close();
                    listBoxFiles.Items.AddRange(LstrList);
                    groupBoxFileList.Visible = true;
                    MobjWizard.AllowNextButton();
                    SetFilePanel(true);
                }
            }
            else if(radioButtonScanFolder.Checked)
            {
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxLocation.Text = folderBrowserDialog.SelectedPath;
                    this.Refresh();
                    groupBoxFileList.Visible = true;
                    new Thread(() =>
                    {
                        textBoxLocation.Invoke(new Action(() => {
                            SetFilePanel(false);
                        }));
                        ScanDirectory(new DirectoryInfo(textBoxLocation.Text));
                        textBoxLocation.Invoke(new Action(() => {
                            MobjWizard.AllowNextButton();
                            SetFilePanel(true);
                        })); 
                    }).Start();
                }
            }
        }

        private void ScanDirectory(DirectoryInfo PobjDir)
        {
            foreach(DirectoryInfo LobjSub in PobjDir.GetDirectories())
            {
                ScanDirectory(LobjSub);
            }
            foreach(FileInfo LobjF in PobjDir.GetFiles())
            {
                textBoxLocation.Invoke(new Action(() => {
                    listBoxFiles.Items.Insert(0, LobjF.FullName.Replace(textBoxLocation.Text, ""));
                })); 
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text File List (*.txt) | *.txt";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter LobjW = new StreamWriter(saveFileDialog.FileName, false);
                foreach(string LobjLine in listBoxFiles.Items)
                {
                    LobjW.WriteLine(LobjLine);
                }
                LobjW.Close();
                MessageBox.Show("File created successfully.");
            }
        }
    }

    public class WizardController
    {
        public delegate void CloseHandler(object Sender, EventArgs args);
        public event CloseHandler Closed;
        public delegate void FinishedHandler(object sender, EventArgs args);
        public event FinishedHandler Finished;
        private int MintCurrentStep = 0;
        private List<Panel> MobjSteps = new List<Panel>();
        private WizardButtons MobjButtons = null;
        public WizardController(WizardButtons PobjButtons, Panel[] PobjPanes)
        {
            MobjSteps.AddRange(PobjPanes);
            MobjButtons = PobjButtons;
            MobjButtons.NextButton.Enabled = false;
            MobjButtons.BackButton.Enabled = false;
            PobjButtons.CancelButton.Click += (o, e) =>
            {
                DialogResult LobjResult = MessageBox.Show("Are you sure you want to cancel and close this wizard?",
                                          Application.ProductName, MessageBoxButtons.YesNoCancel,
                                          MessageBoxIcon.Question);
                if (LobjResult == DialogResult.Yes && Closed != null) Closed(this, new EventArgs());
            };
            PobjButtons.NextButton.Click += (o, e) =>
            {
                NextStep();
            };
            PobjButtons.BackButton.Click += (o, e) =>
            {
                BackStep();
            };
            SetStep(0);
        }
        public void AllowNextButton()
        {
            MobjButtons.NextButton.Enabled = true;
        }
        private void NextStep()
        {
            if(MintCurrentStep == MobjSteps.Count - 1)
            {
                if (Finished != null) Finished(this, new EventArgs());
                return;
            }
            MobjButtons.NextButton.Enabled = false;
            MobjButtons.BackButton.Enabled = true;
            MintCurrentStep++;
            SetStep(MintCurrentStep);
            if(MintCurrentStep >= MobjSteps.Count - 1)
            {
                MobjButtons.NextButton.Text = "&Finish";
            }
        }
        private void BackStep()
        {
            MobjButtons.NextButton.Text = "&Next >";
            MintCurrentStep--;
            SetStep(MintCurrentStep);
            if (MintCurrentStep <= 0) MobjButtons.BackButton.Enabled = false;
            MobjButtons.NextButton.Enabled = true;
        }
        /// <summary>
        /// Sets the current step in the wizard and then disables
        /// the next button and enables the back button
        /// </summary>
        /// <param name="PintStep"></param>
        private void SetStep(int PintStep)
        {
            foreach (Panel LobjItem in MobjSteps)
            {
                LobjItem.Visible = false;
                LobjItem.Top = MobjSteps[0].Top;
                LobjItem.Left = MobjSteps[0].Left;
            }
            if (PintStep >= MobjSteps.Count) return;
            MobjSteps[PintStep].Visible = true;
        }
    }
    public class WizardButtons
    {
        public Button NextButton { get; set; }
        public Button BackButton { get; set; }
        public Button CancelButton { get; set; }
    }
}
