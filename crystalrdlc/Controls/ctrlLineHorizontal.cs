using System;
using System.Drawing;
using System.Windows.Forms;

namespace crystalrdlc
{
    public partial class ctrlLineHorizontal : UserControl
    {
        public ctrlLineHorizontal(){InitializeComponent();}

        private void ctrlLineHorizontal_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.FromName("ControlDark")), this.Width, 0, 0, 0);
            e.Graphics.DrawLine(new Pen(Color.FromName("ControlLightLight")), this.Width, 1, 0, 1);
        }

        private void ctrlLineHorizontal_Resize(object sender, EventArgs e){Height = 2;}
    }
}
