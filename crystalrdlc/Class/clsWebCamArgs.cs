
namespace crystalrdlc
{
    class clsWebCamArgs : System.EventArgs
    {
        private System.Drawing.Image m_Image;
        private ulong m_FrameNumber = 0;

        public clsWebCamArgs() { }

        public System.Drawing.Image WebCamImage
        {
            get { return m_Image; }
            set { m_Image = value; }
        }

        public ulong FrameNumber
        {
            get { return m_FrameNumber; }
            set { m_FrameNumber = value; }
        }
    }
}
