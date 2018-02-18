using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAY_Internet_Of_Things.fridgeapps
{
    class App
    {
        static Stack<Control> appstack = new Stack<Control>();
        FlowLayoutPanel flp { get; }
        PictureBox icon = new PictureBox();
        Label lbl = new Label();
        Control appcontrol { get; }

        public App(Image img,String name,Control control)
        {
            flp = new FlowLayoutPanel();
            flp.BackColor = Color.Black;
            flp.Size = new Size(100, 120);
            icon.Size = new Size(100, 80);
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl.Text = name;
            flp.Controls.Add(icon);
            flp.Controls.Add(lbl);
            appcontrol = control;
            flp.Click += Flp_Click;
        }

        private void Flp_Click(object sender, EventArgs e)
        {
            open_app(appcontrol, flp.Controls.Owner.Controls.Owner);
        }

        public static void open_app(Control app,Control control)
        {
            foreach (Control c in control.Controls){
                appstack.Push(c);
            }
            control.Controls.Clear();
            control.Controls.Add(app);
        }

        public static void go_back(Control owner)
        {
            if (appstack.Count != 0)
            {
                owner.Controls.Clear();
                owner.Controls.Add(appstack.Pop());
            }
        }
    }
}
