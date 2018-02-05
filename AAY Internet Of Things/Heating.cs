using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAY_Internet_Of_Things
{
    public partial class Heating : Form
    {
        public Heating()
        {
            InitializeComponent();
            Canvas c = new Canvas();
            c.Paint += new PaintEventHandler(repaint);
            panel1.Controls.Add(c);
        }

        private void repaint(object sender, PaintEventArgs e)
        {
            int hmax = panel1.Height * 8 / 10;
            int w = 20;
            int r = 25;
            drawThermometer(e.Graphics, Brushes.LightGray, w, hmax, r);

            float ratio = (float)(trackBar1.Value - trackBar1.Minimum) / (trackBar1.Maximum - trackBar1.Minimum);
            Color c = Color.FromArgb((int)(ratio * 255), 0, (int)((1 - ratio) * 255));
            drawThermometer(e.Graphics, new SolidBrush(c), w * 3 / 4, ratio * hmax, r * 3 / 4);

            float celsius = trackBar1.Value;
            float fahrenheit = 1.8f * celsius + 32;
            label1.Text = celsius + " C";
            label2.Text = fahrenheit + " F";
        }

        private void drawThermometer(Graphics g, Brush b, float w, float h, float r)
        {
            g.FillRectangle(b, panel1.Width / 2 - w / 2, panel1.Height * 9 / 10 - h, w, h);
            g.FillEllipse(b, panel1.Width / 2 - r, panel1.Height * 9 / 10 - r, 2 * r, 2 * r);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            panel1.Controls[0].Invalidate();
        }

        private bool active = false;
        private void button1_Click(object sender, EventArgs e)
        {
            active = !active;
            foreach (Control c in this.Controls) c.Visible = active;
            button1.Visible = !active;
            button2.Visible = active;
        }
    }

    public class Canvas : Panel
    {
        public Canvas()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Dock = DockStyle.Fill;
        }
    }
}
