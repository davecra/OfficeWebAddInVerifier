
namespace OfficeWebAddInVerifier
{
    partial class FormWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWizard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelStart = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxManifest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBoxFileList = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.radioButtonSkipFiles = new System.Windows.Forms.RadioButton();
            this.radioButtonScanFolder = new System.Windows.Forms.RadioButton();
            this.radioButtonFileList = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxCreds = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDomain = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.radioButtonProvidedCredentials = new System.Windows.Forms.RadioButton();
            this.radioButtonCurrentUser = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxFileList.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxCreds.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.labelStart);
            this.panel1.Location = new System.Drawing.Point(324, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 781);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 51);
            this.label7.TabIndex = 3;
            this.label7.Text = "Welcome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1008, 250);
            this.label6.TabIndex = 2;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(34, 441);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(287, 65);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(29, 390);
            this.labelStart.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(704, 25);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Click Next to get started, or click Load to load an existing configuration...";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(1436, 821);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(150, 44);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "&Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1274, 821);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 44);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "< &Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1112, 821);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 44);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 781);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSelect);
            this.panel2.Controls.Add(this.textBoxManifest);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(208, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 781);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(1060, 229);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(150, 44);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "&Select...";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxManifest
            // 
            this.textBoxManifest.Location = new System.Drawing.Point(46, 186);
            this.textBoxManifest.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxManifest.Name = "textBoxManifest";
            this.textBoxManifest.ReadOnly = true;
            this.textBoxManifest.Size = new System.Drawing.Size(1170, 31);
            this.textBoxManifest.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1085, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonOpen);
            this.panel3.Controls.Add(this.groupBoxFileList);
            this.panel3.Controls.Add(this.radioButtonSkipFiles);
            this.panel3.Controls.Add(this.radioButtonScanFolder);
            this.panel3.Controls.Add(this.radioButtonFileList);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(156, 84);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 781);
            this.panel3.TabIndex = 4;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(320, 92);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(6);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(160, 63);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "&Open...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Visible = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // groupBoxFileList
            // 
            this.groupBoxFileList.Controls.Add(this.buttonSave);
            this.groupBoxFileList.Controls.Add(this.listBoxFiles);
            this.groupBoxFileList.Controls.Add(this.textBoxLocation);
            this.groupBoxFileList.Location = new System.Drawing.Point(32, 242);
            this.groupBoxFileList.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxFileList.Name = "groupBoxFileList";
            this.groupBoxFileList.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxFileList.Size = new System.Drawing.Size(1196, 508);
            this.groupBoxFileList.TabIndex = 4;
            this.groupBoxFileList.TabStop = false;
            this.groupBoxFileList.Text = "File List";
            this.groupBoxFileList.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1030, 456);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(154, 40);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 25;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 87);
            this.listBoxFiles.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(1168, 354);
            this.listBoxFiles.TabIndex = 1;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(12, 37);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(1168, 31);
            this.textBoxLocation.TabIndex = 0;
            // 
            // radioButtonSkipFiles
            // 
            this.radioButtonSkipFiles.AutoSize = true;
            this.radioButtonSkipFiles.Location = new System.Drawing.Point(32, 175);
            this.radioButtonSkipFiles.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonSkipFiles.Name = "radioButtonSkipFiles";
            this.radioButtonSkipFiles.Size = new System.Drawing.Size(172, 29);
            this.radioButtonSkipFiles.TabIndex = 3;
            this.radioButtonSkipFiles.Text = "S&kip this step";
            this.radioButtonSkipFiles.UseVisualStyleBackColor = true;
            this.radioButtonSkipFiles.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonScanFolder
            // 
            this.radioButtonScanFolder.AutoSize = true;
            this.radioButtonScanFolder.Location = new System.Drawing.Point(32, 131);
            this.radioButtonScanFolder.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonScanFolder.Name = "radioButtonScanFolder";
            this.radioButtonScanFolder.Size = new System.Drawing.Size(221, 29);
            this.radioButtonScanFolder.TabIndex = 2;
            this.radioButtonScanFolder.Text = "&Scan a local folder";
            this.radioButtonScanFolder.UseVisualStyleBackColor = true;
            this.radioButtonScanFolder.CheckedChanged += new System.EventHandler(this.radioButtonScanFolder_CheckedChanged);
            // 
            // radioButtonFileList
            // 
            this.radioButtonFileList.AutoSize = true;
            this.radioButtonFileList.Location = new System.Drawing.Point(32, 87);
            this.radioButtonFileList.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonFileList.Name = "radioButtonFileList";
            this.radioButtonFileList.Size = new System.Drawing.Size(237, 29);
            this.radioButtonFileList.TabIndex = 1;
            this.radioButtonFileList.Text = "&Upload a text file list";
            this.radioButtonFileList.UseVisualStyleBackColor = true;
            this.radioButtonFileList.CheckedChanged += new System.EventHandler(this.radioButtonFileList_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Do you want to verify a list of files or scan an existing folder?";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxCreds);
            this.panel4.Controls.Add(this.radioButtonProvidedCredentials);
            this.panel4.Controls.Add(this.radioButtonCurrentUser);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxUrl);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(95, 140);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1262, 781);
            this.panel4.TabIndex = 1;
            this.panel4.VisibleChanged += new System.EventHandler(this.panel4_VisibleChanged);
            // 
            // groupBoxCreds
            // 
            this.groupBoxCreds.Controls.Add(this.label11);
            this.groupBoxCreds.Controls.Add(this.textBoxDomain);
            this.groupBoxCreds.Controls.Add(this.label10);
            this.groupBoxCreds.Controls.Add(this.textBoxPassword);
            this.groupBoxCreds.Controls.Add(this.label9);
            this.groupBoxCreds.Controls.Add(this.label8);
            this.groupBoxCreds.Controls.Add(this.textBoxUsername);
            this.groupBoxCreds.Location = new System.Drawing.Point(66, 250);
            this.groupBoxCreds.Name = "groupBoxCreds";
            this.groupBoxCreds.Size = new System.Drawing.Size(968, 263);
            this.groupBoxCreds.TabIndex = 5;
            this.groupBoxCreds.TabStop = false;
            this.groupBoxCreds.Text = "Credentials";
            this.groupBoxCreds.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 182);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(779, 50);
            this.label11.TabIndex = 6;
            this.label11.Text = "NOTE: If you are connecting to O365, only the email and password are needed.\r\n   " +
    "         If connecting to a legacy Exchange server, you must provide the domain." +
    "\r\n";
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Location = new System.Drawing.Point(326, 124);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.PasswordChar = '*';
            this.textBoxDomain.Size = new System.Drawing.Size(553, 31);
            this.textBoxDomain.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Domain:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(326, 79);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(553, 31);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email Address/or Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(326, 34);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(553, 31);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // radioButtonProvidedCredentials
            // 
            this.radioButtonProvidedCredentials.AutoSize = true;
            this.radioButtonProvidedCredentials.Location = new System.Drawing.Point(46, 215);
            this.radioButtonProvidedCredentials.Name = "radioButtonProvidedCredentials";
            this.radioButtonProvidedCredentials.Size = new System.Drawing.Size(403, 29);
            this.radioButtonProvidedCredentials.TabIndex = 4;
            this.radioButtonProvidedCredentials.TabStop = true;
            this.radioButtonProvidedCredentials.Text = "Provide credentials to test connection";
            this.radioButtonProvidedCredentials.UseVisualStyleBackColor = true;
            this.radioButtonProvidedCredentials.CheckedChanged += new System.EventHandler(this.radioButtonProvidedCredentials_CheckedChanged);
            // 
            // radioButtonCurrentUser
            // 
            this.radioButtonCurrentUser.AutoSize = true;
            this.radioButtonCurrentUser.Checked = true;
            this.radioButtonCurrentUser.Location = new System.Drawing.Point(46, 171);
            this.radioButtonCurrentUser.Name = "radioButtonCurrentUser";
            this.radioButtonCurrentUser.Size = new System.Drawing.Size(472, 29);
            this.radioButtonCurrentUser.TabIndex = 3;
            this.radioButtonCurrentUser.TabStop = true;
            this.radioButtonCurrentUser.Text = "Use current Windows Credentials to Connect";
            this.radioButtonCurrentUser.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(806, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "NOTE: If you do not supply this, the Exchange Server connection will not be teste" +
    "d.";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(32, 56);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(1192, 31);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "What is the URL to your Exchange server?";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonSaveConfig);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(56, 191);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1262, 781);
            this.panel5.TabIndex = 3;
            this.panel5.VisibleChanged += new System.EventHandler(this.panel5_VisibleChanged);
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Location = new System.Drawing.Point(33, 159);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(216, 59);
            this.buttonSaveConfig.TabIndex = 3;
            this.buttonSaveConfig.Text = "Save Config...";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(899, 125);
            this.label5.TabIndex = 2;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // FormWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 889);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Office Web Add-in Verifier Wizard";
            this.Load += new System.EventHandler(this.FormWizard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBoxFileList.ResumeLayout(false);
            this.groupBoxFileList.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBoxCreds.ResumeLayout(false);
            this.groupBoxCreds.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxManifest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBoxFileList;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.RadioButton radioButtonSkipFiles;
        private System.Windows.Forms.RadioButton radioButtonScanFolder;
        private System.Windows.Forms.RadioButton radioButtonFileList;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxCreds;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.RadioButton radioButtonProvidedCredentials;
        private System.Windows.Forms.RadioButton radioButtonCurrentUser;
    }
}