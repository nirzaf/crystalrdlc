using System;
using System.Windows.Forms;

namespace crystalrdlc
{
    public partial class UpdateDelay : Form
    {
        public UpdateDelay(){InitializeComponent();}

        //INTEGER VARIABLES
        int SECONDS = 10;
        int TMR_COUNT = 0;

        private void UpdateDelay_Load(object sender, EventArgs e)
        {
            try
            {
                picHourGlass.Image = MainForm.publicCustomers.i24x24.Images[6];

                pbUpdate.Minimum = 1;
                pbUpdate.Maximum = SECONDS;
                timerDelay.Enabled = true;
            }
            catch (Exception ex) { }
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            if (TMR_COUNT == SECONDS)
            {
                timerDelay.Enabled = false;
                this.Close();
            }
            else
            {
                TMR_COUNT = TMR_COUNT + 1;
                pbUpdate.Value = TMR_COUNT;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            picHourGlass.Image = MainForm.publicCustomers.i24x24.Images[9];
            timer4.Enabled = !timer4.Enabled;
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            picHourGlass.Image = MainForm.publicCustomers.i24x24.Images[8];
            timer3.Enabled = !timer3.Enabled;
            timer4.Enabled = !timer4.Enabled;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            picHourGlass.Image = MainForm.publicCustomers.i24x24.Images[7];
            timer2.Enabled = !timer2.Enabled;
            timer3.Enabled = !timer3.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picHourGlass.Image = MainForm.publicCustomers.i24x24.Images[6];
            timer1.Enabled = !timer1.Enabled;
            timer2.Enabled = !timer2.Enabled;
        }
    }
}