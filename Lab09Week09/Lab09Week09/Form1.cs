using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab09Week09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(panel1.ClientRectangle);
            PathGradientBrush br = new PathGradientBrush(path);
            br.CenterPoint = new PointF(panel1.ClientRectangle.Width / 2, panel1.ClientRectangle.Height / 2);
            br.CenterColor = Color.Navy;
            br.SurroundColors = new Color[] { Color.Yellow };
            e.Graphics.FillPath(br, path);
        }
    }
}
