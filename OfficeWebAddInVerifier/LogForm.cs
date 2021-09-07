using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeWebAddInVerifier
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            
        }

        public void LogItem(string PstrData, bool PbolSuccess)
        {
            ListViewItem LobjItem = new ListViewItem(PstrData);
            if (PbolSuccess == false)
            {
                LobjItem.BackColor = Color.DarkRed;
                LobjItem.ForeColor = Color.White;
            }
            else
            {
                LobjItem.BackColor = Color.LightGreen;
            }
            listViewResults.Items.Insert(0, LobjItem);
        }

        public void Notification(string PstrMessage)
        {
            toolStripStatusUpdates.Text = PstrMessage;
        }

        private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog LobjSaveFileDialog = new SaveFileDialog();
            LobjSaveFileDialog.Filter = "Log File (*.log)|*.log";
            if(LobjSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter LobjWrite = new StreamWriter(LobjSaveFileDialog.FileName);
                foreach (ListViewItem LobjItem in listViewResults.Items)
                {
                    LobjWrite.WriteLine(LobjItem.Text);
                }
                LobjWrite.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
