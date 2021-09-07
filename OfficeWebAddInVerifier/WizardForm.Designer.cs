
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonScanFolder = new System.Windows.Forms.RadioButton();
            this.radioButtonFileList = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxFileList.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel3.Controls.Add(this.radioButton1);
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 175);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(172, 29);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "S&kip this step";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxUrl);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(94, 135);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1262, 781);
            this.panel4.TabIndex = 1;
            this.panel4.VisibleChanged += new System.EventHandler(this.panel4_VisibleChanged);
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
            // FormWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 889);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.RadioButton radioButton1;
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
    }
}