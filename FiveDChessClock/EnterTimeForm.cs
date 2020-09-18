using System;
using System.Windows.Forms;

namespace FiveDChessClock
{
    public partial class EnterTimeForm : Form
    {
        public long CurrentTime { get; private set; }

        public EnterTimeForm(long currentTime)
        {
            InitializeComponent();
            this.CurrentTime = currentTime;
        }

        private void BtnSaveTime_Click(object sender, EventArgs e)
        {
            this.CurrentTime = (((long)this.NumHrs.Value * 60 + (long)this.NumMins.Value) * 60 + (long)this.NumSecs.Value) * 1000;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EnterTimeForm_Load(object sender, EventArgs e)
        {
            var milliseconds = this.CurrentTime;

            int popMaxAmountFromMs(long valueToPop)
            {
                var ret = milliseconds / valueToPop;
                milliseconds -= ret * valueToPop;
                return (int)ret;
            }

            var hrs = popMaxAmountFromMs(60 * 60 * 1000);
            var mins = popMaxAmountFromMs(60 * 1000);
            var secs = popMaxAmountFromMs(1000);

            this.NumHrs.Value = hrs;
            this.NumMins.Value = mins;
            this.NumSecs.Value = secs;
        }
    }
}
