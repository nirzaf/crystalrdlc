using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace crystalrdlc
{
    [ToolboxBitmap(typeof(ctrlCamera), "Camera.ico")] // toolbox bitmap
    [Designer("Sytem.Windows.Forms.Design.ParentControlDesigner,System.Design", typeof(IDesigner))] // make composite

    public partial class ctrlCamera : UserControl
    {
        public ctrlCamera() { InitializeComponent(); }

        // property variables
        private int m_TimeToCapture_milliseconds = 100;
        private int m_Width = 320;
        private int m_Height = 240;
        private int mCapHwnd;
        private ulong m_FrameNumber = 0;

        // global variables to make the video capture go faster
        private crystalrdlc.clsWebCamArgs x = new crystalrdlc.clsWebCamArgs();
        private IDataObject tempObj;
        private Image tempImg;
        private bool bStopped = true;

        // event delegate
        public delegate void WebCamEventHandler(object source, crystalrdlc.clsWebCamArgs e);
        // fired when a new image is captured
        public event WebCamEventHandler ImageCaptured;

        #region API Declarations

        [DllImport("user32", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        [DllImport("avicap32.dll", EntryPoint = "capCreateCaptureWindowA")]
        public static extern int capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, int hwndParent, int nID);

        [DllImport("user32", EntryPoint = "OpenClipboard")]
        public static extern int OpenClipboard(int hWnd);

        [DllImport("user32", EntryPoint = "EmptyClipboard")]
        public static extern int EmptyClipboard();

        [DllImport("user32", EntryPoint = "CloseClipboard")]
        public static extern int CloseClipboard();

        #endregion

        #region API Constants
        public const int WM_USER = 1024;

        public const int WM_CAP_CONNECT = 1034;
        public const int WM_CAP_DISCONNECT = 1035;
        public const int WM_CAP_GET_FRAME = 1084;
        public const int WM_CAP_COPY = 1054;
        public const int WM_CAP_START = WM_USER;
        public const int WM_CAP_DLG_VIDEOFORMAT = WM_CAP_START + 41;
        public const int WM_CAP_DLG_VIDEOSOURCE = WM_CAP_START + 42;
        public const int WM_CAP_DLG_VIDEODISPLAY = WM_CAP_START + 43;
        public const int WM_CAP_GET_VIDEOFORMAT = WM_CAP_START + 44;
        public const int WM_CAP_SET_VIDEOFORMAT = WM_CAP_START + 45;
        public const int WM_CAP_DLG_VIDEOCOMPRESSION = WM_CAP_START + 46;
        public const int WM_CAP_SET_PREVIEW = WM_CAP_START + 50;
        #endregion

        #region Control Properties
        public int TimeToCapture_milliseconds
        {
            get { return m_TimeToCapture_milliseconds; }
            set { m_TimeToCapture_milliseconds = value; }
        }

        public int CaptureHeight
        {
            get { return m_Height; }
            set { m_Height = value; }
        }

        public int CaptureWidth
        {
            get { return m_Width; }
            set { m_Width = value; }
        }

        public ulong FrameNumber
        {
            get { return m_FrameNumber; }
            set { m_FrameNumber = value; }
        }
        #endregion

        #region Start and Stop Capture Functions

        public void Start(ulong FrameNum)
        {
            try
            {
                // for safety, call stop, just in case we are already running
                this.Stop();

                // setup a capture window
                mCapHwnd = capCreateCaptureWindowA("WebCap", 0, 0, 0, m_Width, m_Height, this.Handle.ToInt32(), 0);

                // connect to the capture device
                Application.DoEvents();
                SendMessage(mCapHwnd, WM_CAP_CONNECT, 0, 0);
                SendMessage(mCapHwnd, WM_CAP_SET_PREVIEW, 0, 0);

                // set the frame number
                m_FrameNumber = FrameNum;

                // set the timer information
                this.timer1.Interval = m_TimeToCapture_milliseconds;
                bStopped = false;
                this.timer1.Start();
            }

            catch (Exception excep)
            {
                MessageBox.Show("An error ocurred while starting the video capture. Check that your webcamera is connected properly and turned on.\r\n\n" + excep.Message);
                this.Stop();
            }
        }

        public void Stop()
        {
            try
            {
                // stop the timer
                bStopped = true;
                this.timer1.Stop();

                // disconnect from the video source
                Application.DoEvents();
                SendMessage(mCapHwnd, WM_CAP_DISCONNECT, 0, 0);
            }

            catch (Exception excep)
            { // don't raise an error here.
            }

        }
        #endregion

        #region Video Capture Code
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // pause the timer
                this.timer1.Stop();

                // get the next frame;
                SendMessage(mCapHwnd, WM_CAP_GET_FRAME, 0, 0);

                // copy the frame to the clipboard
                SendMessage(mCapHwnd, WM_CAP_COPY, 0, 0);

                // paste the frame into the event args image
                if (ImageCaptured != null)
                {
                    // get from the clipboard
                    tempObj = Clipboard.GetDataObject();
                    tempImg = (Bitmap)tempObj.GetData(DataFormats.Bitmap);

                    x.WebCamImage = tempImg.GetThumbnailImage(m_Width, m_Height, null, IntPtr.Zero);

                    // raise the event
                    this.ImageCaptured(this, x);
                }

                // restart the timer
                Application.DoEvents();
                if (!bStopped)
                    this.timer1.Start();
            }

            catch (Exception excep)
            {
                MessageBox.Show("An error ocurred while capturing the video image. The video capture will now be terminated.\r\n\n" + excep.Message);
                this.Stop(); // stop the process
            }
        }
        #endregion
    }
}
