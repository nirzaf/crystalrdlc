using System;
using System.IO;
using System.Windows.Forms;

namespace crystalrdlc
{
    public partial class WebCamera : Form
    {
        public WebCamera(){InitializeComponent();}

        //STRING VARIABLES
        public static string sSelect;

        //BOOLEAN VARIABLES
        public static bool boolGets;
        public static bool boolFill;

        //INTEGER VARIABLES
        private int SECONDS = 10;
        private int TMR_COUNT = 0;

        private void ctrlCamera1_ImageCaptured(object source, clsWebCamArgs e)
        {
            try { picCamera.Image = e.WebCamImage; }
            catch (Exception ex) { }
        }

        private void WebCamera_Load(object sender, EventArgs e)
        {
            try
            {
                setImages();

                // set the image capture size
                ctrlCamera1.CaptureHeight = picCamera.Height;
                ctrlCamera1.CaptureWidth = picCamera.Width;

                ctrlCamera1.TimeToCapture_milliseconds = 100;
                ctrlCamera1.Start(0);
            }
            catch (Exception ex) { }
        }

        protected void setImages()
        {
            //Buttons
            bttnCancel.Image = MainForm.publicCustomers.i32x32.Images[9];
            bttnProcess.Image = MainForm.publicCustomers.i32x32.Images[7];

            //Picturebox
            picHourGlass.Image = MainForm.publicCustomers.i24x24.Images[6];
        }

        private void WebCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { ctrlCamera1.Stop(); }
            catch (Exception ex) { }
        }

        private void bttnCancel_Click(object sender, EventArgs e) { this.Close(); }

        private void bttnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                bttnProcess.Enabled = false;
                bttnCancel.Enabled = false;
                ctrlCamera1.Stop();
                picCamera.Image = picCamera.Image;
                pbUpdate.Minimum = 1;
                pbUpdate.Maximum = SECONDS;
                timerDelay.Enabled = true;
            }
            catch (Exception ex) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picHourGlass.Image = MainForm.publicCustomers.i24x24.Images[6];
            timer1.Enabled = !timer1.Enabled;
            timer2.Enabled = !timer2.Enabled;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            picHourGlass.Image = MainForm.publicCustomers.i24x24.Images[7];
            timer2.Enabled = !timer2.Enabled;
            timer3.Enabled = !timer3.Enabled;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            picHourGlass.Image = MainForm.publicCustomers.i24x24.Images[8];
            timer3.Enabled = !timer3.Enabled;
            timer4.Enabled = !timer4.Enabled;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            picHourGlass.Image = MainForm.publicCustomers.i24x24.Images[9];
            timer4.Enabled = !timer4.Enabled;
            timer1.Enabled = !timer1.Enabled;
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            try
            {
                if (TMR_COUNT == SECONDS)
                {
                    if (sSelect == "Customer Picture")
                    {
                        clsADONET.setRemoveFile("CustPic.tmp", Path.GetTempPath().ToString() + "\\Customers Pics\\");
                        clsADONET.setCreateFile(picCamera, "CustPic.tmp", Path.GetTempPath().ToString() + "\\Customers Pics\\");
                        frmCustomers_Modify.publicCustModify.setPicture(Path.GetTempPath().ToString() + "\\Customers Pics\\CustPic.tmp", true);
                    }
                    timerDelay.Enabled = false;
                    this.Close();
                }
                else
                {
                    timer1.Enabled = true;
                    TMR_COUNT = TMR_COUNT + 1;
                    pbUpdate.Value = TMR_COUNT;
                }
            }
            catch (Exception ex) { }

        }
    }
}