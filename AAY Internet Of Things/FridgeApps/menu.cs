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
        public Menu(EventHandler iconClick)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.AddRange(new Control[] {
                new MenuIcon(Properties.Resources.if_Recipe_Book_89064,"Συνταγές",new Recipes(), iconClick),
                new MenuIcon(Properties.Resources.AlanSpeak_Fridge_open_300px, "Εσωτερικό ψυγείου", new Camera(), iconClick),
                new MenuIcon(Properties.Resources.browser_icon, "Internet", new Internet(), iconClick),
                new MenuIcon(Properties.Resources.weather, "Καιρός", new Weather(), iconClick),
                new MenuIcon(null, "Ημερολόγιο", null, iconClick)});
        }
    }

    class MenuIcon : FlowLayoutPanel
    {
        public MenuIcon(Image img, String name, Control target, EventHandler icon_Click) : base()
        {
            this.Size = new Size(80, 120);
            PictureBox icon = new PictureBox();
            icon.Size = new Size(80, 80);
            icon.Margin = Padding.Empty; //gia to bug pou kovotan de3ia
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.Image = img;
            icon.Click += icon_Click;
            icon.Cursor = Cursors.Hand;
            Label lbl = new Label();
            lbl.Text = name;
            lbl.TextAlign = ContentAlignment.MiddleCenter; //gia na
            lbl.AutoSize = false; // menei katw
            lbl.Width = icon.Width; // apo thn eikona
            lbl.Height = 40;
            this.Controls.Add(icon);
            this.Controls.Add(lbl);
            this.Tag = target;
            this.Margin = new Padding(10);
        }
    }
}
