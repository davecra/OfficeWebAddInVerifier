
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.panel1.Controls.Add(this.labelStart);
            this.panel1.Location = new System.Drawing.Point(162, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 406);
            this.panel1.TabIndex = 0;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(13, 13);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(129, 13);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Click Next to get started...";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(718, 427);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "&Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(637, 427);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "< &Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(556, 427);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 406);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSelect);
            this.panel2.Controls.Add(this.textBoxManifest);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(104, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 406);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(533, 142);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "&Select...";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxManifest
            // 
            this.textBoxManifest.Location = new System.Drawing.Point(21, 116);
            this.textBoxManifest.Name = "textBoxManifest";
            this.textBoxManifest.ReadOnly = true;
            this.textBoxManifest.Size = new System.Drawing.Size(587, 20);
            this.textBoxManifest.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the manifest...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonOpen);
            this.panel3.Controls.Add(this.groupBoxFileList);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.radioButtonScanFolder);
            this.panel3.Controls.Add(this.radioButtonFileList);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(81, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 406);
            this.panel3.TabIndex = 4;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(160, 48);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(80, 33);
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
            this.groupBoxFileList.Location = new System.Drawing.Point(16, 126);
            this.groupBoxFileList.Name = "groupBoxFileList";
            this.groupBoxFileList.Size = new System.Drawing.Size(598, 264);
            this.groupBoxFileList.TabIndex = 4;
            this.groupBoxFileList.TabStop = false;
            this.groupBoxFileList.Text = "File List";
            this.groupBoxFileList.Visible = false;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(6, 45);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(586, 186);
            this.listBoxFiles.TabIndex = 1;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(6, 19);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(586, 20);
            this.textBoxLocation.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 91);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "S&kip this step";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonScanFolder
            // 
            this.radioButtonScanFolder.AutoSize = true;
            this.radioButtonScanFolder.Location = new System.Drawing.Point(16, 68);
            this.radioButtonScanFolder.Name = "radioButtonScanFolder";
            this.radioButtonScanFolder.Size = new System.Drawing.Size(113, 17);
            this.radioButtonScanFolder.TabIndex = 2;
            this.radioButtonScanFolder.Text = "&Scan a local folder";
            this.radioButtonScanFolder.UseVisualStyleBackColor = true;
            this.radioButtonScanFolder.CheckedChanged += new System.EventHandler(this.radioButtonScanFolder_CheckedChanged);
            // 
            // radioButtonFileList
            // 
            this.radioButtonFileList.AutoSize = true;
            this.radioButtonFileList.Location = new System.Drawing.Point(16, 45);
            this.radioButtonFileList.Name = "radioButtonFileList";
            this.radioButtonFileList.Size = new System.Drawing.Size(119, 17);
            this.radioButtonFileList.TabIndex = 1;
            this.radioButtonFileList.Text = "&Upload a text file list";
            this.radioButtonFileList.UseVisualStyleBackColor = true;
            this.radioButtonFileList.CheckedChanged += new System.EventHandler(this.radioButtonFileList_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Do you want to verify a list of files or scan an existing folder?";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxUrl);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(47, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(631, 406);
            this.panel4.TabIndex = 1;
            this.panel4.VisibleChanged += new System.EventHandler(this.panel4_VisibleChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "NOTE: If you do not supply this, the Exchange Server connection will not be teste" +
    "d.";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(16, 29);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(598, 20);
            this.textBoxUrl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "What is the URL to your Exchange server?";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(30, 99);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(631, 406);
            this.panel5.TabIndex = 3;
            this.panel5.VisibleChanged += new System.EventHandler(this.panel5_VisibleChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "You are all done. Click Finish to run the report.";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(515, 237);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(77, 21);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 462);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}