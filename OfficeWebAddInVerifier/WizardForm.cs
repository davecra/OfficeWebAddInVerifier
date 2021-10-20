using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
                // at this point we need to see what type of add-in this is.
                // If it is an EXCHANGE / OWA / OUTLOOK add-in we will need to show the
                // Exchange ASMX request page...
                if(ManifestVerifier.WhatTypeIsThis(textBoxManifest.Text) != ManifestVerifier.ADDIN_TYPE.Outlook)
                {
                    // we do not have an exhange addin, so we will remove panel4
                    MobjWizard.RemovePanel(panel4);
                }
                else
                {
                    textBoxUrl.Text = "https://outlook.com/ews/exchange.asmx";
                }
                MobjWizard.AllowNextButton();
            }
        }

        /// <summary>
        /// When the form loads, attached the Wizard class to the form to allow it to be
        /// controlled by the wizard class for determineing the behavior of the next
        /// buttons and back buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                NetworkCredential LobjCreds = new NetworkCredential();
                if(radioButtonCurrentUser.Checked)
                {
                    LobjCreds = CredentialCache.DefaultNetworkCredentials;
                }
                else if(radioButtonProvidedCredentials.Checked && !string.IsNullOrEmpty(textBoxDomain.Text))
                {
                    LobjCreds = new NetworkCredential(textBoxUsername.Text, textBoxPassword.Text, textBoxDomain.Text);
                }
                else
                {
                    LobjCreds = new NetworkCredential(textBoxUsername.Text, textBoxPassword.Text);
                }
                // load up the verifier and then check
                ManifestVerifier LobjVerifier = new ManifestVerifier(textBoxManifest.Text, 
                                                                     listBoxFiles.Items.ToList(),
                                                                     textBoxUrl.Text,
                                                                     LobjCreds);
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

        /// <summary>
        /// User selected to laod a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// User selected to scan a folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// User selected to open an existing file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            buttonOpen.Visible = false;
            groupBoxFileList.Visible = false;
            MobjWizard.AllowNextButton();
        }

        /// <summary>
        /// When the panel become visible, we allow the next button
        /// if the text is already in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel4_VisibleChanged(object sender, EventArgs e)
        {
            if(MobjWizard != null && !string.IsNullOrEmpty(textBoxUrl.Text)) MobjWizard.AllowNextButton();
        }

        /// <summary>
        /// When the panel becomes visible, allow the next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel5_VisibleChanged(object sender, EventArgs e)
        {
            if(MobjWizard != null) MobjWizard.AllowNextButton();
        }

        /// <summary>
        /// Sets the enabled value of all the buttons and selections on the 
        /// FileList panel
        /// </summary>
        /// <param name="PbolEnabled"></param>
        private void SetFilePanel(bool PbolEnabled)
        {
            buttonOpen.Enabled = PbolEnabled;
            buttonBack.Enabled = PbolEnabled;
            radioButtonFileList.Enabled = PbolEnabled;
            radioButtonScanFolder.Enabled = PbolEnabled;
            radioButtonSkipFiles.Enabled = PbolEnabled;
            buttonSave.Enabled = PbolEnabled;
        }

        /// <summary>
        /// User clicked the open button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// User clicked the scan directory button
        /// </summary>
        /// <param name="PobjDir"></param>
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

        /// <summary>
        /// User clicked NEXT
        /// NOTE: we should do nothing here and allow the Wizard class to handle this 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The user wants to save the current wizard configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            // create the config
            VerificationConfiguration LobjConfig = new VerificationConfiguration();
            LobjConfig.Asmx = textBoxUrl.Text;
            LobjConfig.ManifestPath = textBoxManifest.Text;
            LobjConfig.Files = listBoxFiles.Items.ToList();
            LobjConfig.GetManifestAsBase64();
            LobjConfig.UseDefaultCredentials = radioButtonCurrentUser.Checked;
            LobjConfig.UserName = textBoxUsername.Text;
            LobjConfig.Domain = textBoxDomain.Text;
            saveFileDialog.Filter = "Addin Verifier Configuration (*.config) | *.config";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter LobjW = new StreamWriter(saveFileDialog.FileName, false);
                LobjW.WriteLine(JsonConvert.SerializeObject(LobjConfig));
                LobjW.Close();
                MessageBox.Show("Config file created successfully.");
            }
        }

        /// <summary>
        /// User clicked the Load button to load an existing configuration
        /// we need to setup the form and enable parts of the wizard to allow
        /// next, next, next....
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Addin Verifier Configuration (*.config) | *.config";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader LobjR = new StreamReader(openFileDialog.FileName);
                VerificationConfiguration LobjConfig =  JsonConvert.DeserializeObject<VerificationConfiguration>(LobjR.ReadToEnd());
                textBoxUrl.Text = LobjConfig.Asmx;
                textBoxManifest.Text = LobjConfig.ManifestPath;
                if(LobjConfig.UseDefaultCredentials)
                {
                    radioButtonCurrentUser.Checked = true;
                }
                else
                {
                    radioButtonProvidedCredentials.Checked = true;
                    textBoxUsername.Text = LobjConfig.UserName;
                    textBoxDomain.Text = LobjConfig.Domain;
                }
                if (LobjConfig.Files.Count > 0)
                {
                    listBoxFiles.Items.AddRange(LobjConfig.Files.ToArray());
                    radioButtonFileList.Checked = true;
                }
                else
                {
                    radioButtonSkipFiles.Checked = true;
                }
                if(listBoxFiles.Items.Count > 0)
                {
                    radioButtonFileList.Checked = true;
                    groupBoxFileList.Visible = true;
                }
                MessageBox.Show("Config file loaded successfully.");
                MobjWizard.EnableAllSteps = true;
            }
        }

        /// <summary>
        /// User entered a value into the textbox
        /// Enable the next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {
            if (MobjWizard != null)
            {
                if(radioButtonCurrentUser.Checked) MobjWizard.AllowNextButton();
                else if(radioButtonProvidedCredentials.Checked &&
                        textBoxUsername.Text != "" &&
                        textBoxPassword.Text != "") MobjWizard.AllowNextButton();
            }
        }

        /// <summary>
        /// The user is providing credentials to connect to the excahnge server to
        /// test the EWS settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonProvidedCredentials_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCreds.Visible = radioButtonProvidedCredentials.Checked;

        }

        /// <summary>
        /// Make sure a username and apssword are supplied
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (MobjWizard != null)
            {
                if (radioButtonCurrentUser.Checked) MobjWizard.AllowNextButton();
                else if (radioButtonProvidedCredentials.Checked &&
                        textBoxUsername.Text != "" &&
                        textBoxPassword.Text != "") MobjWizard.AllowNextButton();
            }
        }

        /// <summary>
        /// Make sure a username and password are supplied
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (MobjWizard != null)
            {
                if (radioButtonCurrentUser.Checked) MobjWizard.AllowNextButton();
                else if (radioButtonProvidedCredentials.Checked &&
                        textBoxUsername.Text != "" &&
                        textBoxPassword.Text != "") MobjWizard.AllowNextButton();
            }
        }
    }
}
