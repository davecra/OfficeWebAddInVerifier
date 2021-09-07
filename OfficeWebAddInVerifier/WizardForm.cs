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
using Newtonsoft.Json;
using OfficeWebAddInVerifier.Wizard;

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
            this.Width = pictureBox1.Left + pictureBox1.Width + 5 + panel1.Width + 20;
            buttonNext.Left = this.Width - buttonNext.Width - 20;
            buttonBack.Left = buttonNext.Left - buttonBack.Width - 5;
            buttonCancel.Left = buttonBack.Left - buttonCancel.Width - 5;
            MobjWizard = new WizardController(new WizardButtons() { BackButton = buttonBack, CancelButton = buttonCancel, NextButton = buttonNext },
                                              new[] { panel1, panel2, panel3, panel4, panel5 });
            MobjWizard.Closed += (o, ev) => { this.Close(); };
            MobjWizard.Finished += (o, ev) =>
            {
                // load up the verifier and then check
                ManifestVerifier LobjVerifier = new ManifestVerifier(textBoxManifest.Text, listBoxFiles.Items.ToList());
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
                openFileDialog.InitialDirectory = new FileInfo(textBoxManifest.Text).Directory.FullName;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxLocation.Text = openFileDialog.FileName;
                    this.Refresh();
                    SetFilePanel(false);
                    // get the files
                    StreamReader LobjReader = new StreamReader(textBoxLocation.Text);
                    string[] LstrList = LobjReader.ReadToEnd().Split('\n');
                    LobjReader.Close();
                    listBoxFiles.Items.Clear();
                    listBoxFiles.Items.AddRange(LstrList);
                    groupBoxFileList.Visible = true;
                    MobjWizard.AllowNextButton();
                    SetFilePanel(true);
                }
            }
            else if(radioButtonScanFolder.Checked)
            {
                folderBrowserDialog.ShowNewFolderButton = false;
                folderBrowserDialog.Description = "Select the publish folder for your add-in";
                folderBrowserDialog.SelectedPath = new FileInfo(textBoxManifest.Text).Directory.FullName;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
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

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            // create the config
            VerificationConfiguration LobjConfig = new VerificationConfiguration();
            LobjConfig.Asmx = textBoxUrl.Text;
            LobjConfig.ManifestPath = textBoxManifest.Text;
            LobjConfig.Files = listBoxFiles.Items.ToList();
            LobjConfig.GetManifestAsBase64();
            saveFileDialog.Filter = "Addin Verifier Configuration (*.config) | *.config";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter LobjW = new StreamWriter(saveFileDialog.FileName, false);
                LobjW.WriteLine(JsonConvert.SerializeObject(LobjConfig));
                LobjW.Close();
                MessageBox.Show("Config file created successfully.");
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Addin Verifier Configuration (*.config) | *.config";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader LobjR = new StreamReader(openFileDialog.FileName);
                VerificationConfiguration LobjConfig =  JsonConvert.DeserializeObject<VerificationConfiguration>(LobjR.ReadToEnd());
                textBoxUrl.Text = LobjConfig.Asmx;
                textBoxManifest.Text = LobjConfig.ManifestPath;
                listBoxFiles.Items.AddRange(LobjConfig.Files.ToArray());
                if(listBoxFiles.Items.Count > 0)
                {
                    radioButtonFileList.Checked = true;
                    groupBoxFileList.Visible = true;
                }
                MessageBox.Show("Config file loaded successfully.");
                MobjWizard.EnableAllSteps = true;
            }
        }
    }
}
