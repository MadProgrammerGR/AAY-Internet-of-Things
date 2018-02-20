using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAY_Internet_Of_Things.FridgeApps
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(
                new MenuIcon(Properties.Resources.if_Recipe_Book_89064,"Συνταγές",new Recipes()).flp);
            flowLayoutPanel1.Controls.Add(
                new MenuIcon(Properties.Resources.AlanSpeak_Fridge_open_300px, "Εσωτερικό ψτγείου", new Camera()).flp);
            flowLayoutPanel1.Controls.Add(
                new MenuIcon(Properties.Resources.browser_icon, "Internet", new Internet()).flp);
            flowLayoutPanel1.Controls.Add(
                new MenuIcon(null,"Kairos",null).flp);
            flowLayoutPanel1.Controls.Add(
                new MenuIcon(null, "Hmerologio", null).flp);
        }

        class MenuIcon
        {
            public FlowLayoutPanel flp { get; }
            PictureBox icon = new PictureBox();
            Label lbl = new Label();
            Control appcontrol { get; }

            public MenuIcon(System.Drawing.Image img, String name, Control control)
            {
                flp = new FlowLayoutPanel();
                flp.Size = new Size(80, 120);
                icon.Size = new Size(80, 80);
                icon.SizeMode = PictureBoxSizeMode.StretchImage;
                icon.Image = img;
                lbl.Text = name;
                flp.Controls.Add(icon);
                flp.Controls.Add(lbl);
                appcontrol = control;
                icon.Click += icon_Click;
            }

            private void icon_Click(object sender, EventArgs e)
            {
                if (!Fridge.apps.ContainsKey(lbl.Text))
                    Fridge.apps.Add(lbl.Text, appcontrol);
                Fridge.history.Push(lbl.Text);
                Control fridgepanel = flp.Parent.Parent.Parent;
                fridgepanel.Controls.Clear();
                fridgepanel.Controls.Add(appcontrol);
            }
        }
        }
}
