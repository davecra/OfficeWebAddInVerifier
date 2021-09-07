using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeWebAddInVerifier.Wizard
{
    public class WizardController
    {
        public delegate void CloseHandler(object Sender, EventArgs args);
        public event CloseHandler Closed;
        public delegate void FinishedHandler(object sender, EventArgs args);
        public event FinishedHandler Finished;
        private int MintCurrentStep = 0;
        private List<Panel> MobjSteps = new List<Panel>();
        private WizardButtons MobjButtons = null;
        public bool EnableAllSteps { get; set; }
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
            if (MintCurrentStep == MobjSteps.Count - 1)
            {
                if (Finished != null) Finished(this, new EventArgs());
                return;
            }
            MobjButtons.NextButton.Enabled = false || EnableAllSteps;
            MobjButtons.BackButton.Enabled = true;
            MintCurrentStep++;
            SetStep(MintCurrentStep);
            if (MintCurrentStep >= MobjSteps.Count - 1)
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
}
