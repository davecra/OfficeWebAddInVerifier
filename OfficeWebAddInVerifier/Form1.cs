using System;
using System.Drawing;
using System.Windows.Forms;
using OfficeWebAddInVerifier.ManifestParts;

namespace OfficeWebAddInVerifier
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// CTOR
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// User click the verify button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVerify_Click(object sender, EventArgs e)
        {
            // disable the buttons
            buttonOpen.Enabled = false;
            buttonVerify.Enabled = false;
            listViewResults.Items.Clear();
            // load up the verifier and then check
            ManifestVerifier LobjVerifier = new ManifestVerifier(openManifestFileDialog.FileName);
            LobjVerifier.LogEvent += LobjVerifier_LogEvent;
            LobjVerifier.NotificationEvent += LobjVerifier_NotificationEvent;
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
                MessageBox.Show("The manifest has been fully verified.",
                                Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // at the very end, we enable to open button again
            buttonOpen.Enabled = true;
        }
        /// <summary>
        /// Updates the status pane with information from the caller
        /// </summary>
        /// <param name="PobjSender"></param>
        /// <param name="PobjEvent"></param>
        private void LobjVerifier_NotificationEvent(object PobjSender, NotifyEventArgs PobjEvent)
        {
            toolStripStatusUpdates.Text = PobjEvent.Message;
        }

        /// <summary>
        /// Incoming event to show log messages in the results textbox
        /// </summary>
        /// <param name="PobjServer"></param>
        /// <param name="PobjEvent"></param>
        private void LobjVerifier_LogEvent(object PobjServer, OutputHandlerArgs PobjEvent)
        {
            ListViewItem LobjItem = new ListViewItem(PobjEvent.Message);
            if (PobjEvent.Success == false)
            {
                LobjItem.BackColor = Color.Red;
            }
            else
            {
                LobjItem.BackColor = Color.Green;
            }
            listViewResults.Items.Insert(0,LobjItem);
        }

        /// <summary>
        /// User clicked on the (...) / Open button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openManifestFileDialog.ShowDialog() == DialogResult.OK)
            {
                buttonVerify.Enabled = true;
                textBox1.Text = openManifestFileDialog.FileName;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult LobjResult = MessageBox.Show("Click yes, if you want to scan a directory, click no, if you want to select a file");
        }

        private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
