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
                new MenuIcon(Properties.Resources.if_Recipe_Book_89064,"Συνταγές",new Recipes(), iconClick, iconDragStart, iconMove, iconDragEnd),
                new MenuIcon(Properties.Resources.AlanSpeak_Fridge_open_300px, "Εσωτερικό ψυγείου", new Camera(), iconClick, iconDragStart, iconMove, iconDragEnd),
                new MenuIcon(Properties.Resources.browser_icon, "Internet", new Internet(), iconClick, iconDragStart, iconMove, iconDragEnd),
                new MenuIcon(Properties.Resources.weather, "Καιρός", new Weather(), iconClick, iconDragStart, iconMove, iconDragEnd),
                new MenuIcon(Properties.Resources.CalendarIcon, "Ημερολόγιο", new Calendar(), iconClick, iconDragStart, iconMove, iconDragEnd),
                new MenuIcon(Properties.Resources.RadioIcon,"Ραδιόφωνο",(new Radio()).panel1,iconClick,iconDragStart,iconMove,iconDragEnd)
            });
                
        }

        public MenuIcon draggedIcon = null;
        private Point startLoc;
        private void iconDragStart(object sender, MouseEventArgs e){
            if (sender as PictureBox == null) return; //bug fix, merikes fores dinei sender to flowlayout
            draggedIcon = (MenuIcon)((PictureBox)sender).Parent;
            draggedIcon.Parent = this;
            draggedIcon.BringToFront();
            startLoc = e.Location;
        }

        private void iconMove(object sender, MouseEventArgs e){
            if (draggedIcon == null) return; //otan den sernei tpt
            draggedIcon.Location = new Point(draggedIcon.Location.X + e.X - startLoc.X, draggedIcon.Location.Y + e.Y - startLoc.Y);
        }

        private void iconDragEnd(object sender, MouseEventArgs e)
        {
            if (draggedIcon == null) return;
            Point targetLoc = new Point(draggedIcon.Location.X + e.X, draggedIcon.Location.Y + e.Y);
            MenuIcon target = flowLayoutPanel1.GetChildAtPoint(targetLoc) as MenuIcon;
            flowLayoutPanel1.Controls.Add(draggedIcon); //to vazei sto telos
            if (target != null){ //kai to metakinei sth swsth 8esh
                int k = flowLayoutPanel1.Controls.IndexOf(target);
                flowLayoutPanel1.Controls.SetChildIndex(draggedIcon, k);
            }
            draggedIcon = null;
        }

    }

    public class MenuIcon : FlowLayoutPanel
    {
        public MenuIcon(Image img, String name, Control target, 
            EventHandler icon_Click, MouseEventHandler start, MouseEventHandler move, MouseEventHandler end) : base()
        {
            this.Size = new Size(80, 120);
            PictureBox icon = new PictureBox();
            icon.Size = new Size(80, 80);
            icon.Margin = Padding.Empty; //gia to bug pou kovotan de3ia
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.Image = img;
            icon.DoubleClick += icon_Click;
            icon.MouseDown += start;
            icon.MouseMove += move;
            icon.MouseUp += end;
            icon.Cursor = Cursors.Hand;
            Label lbl = new Label();
            lbl.Text = name;
            lbl.TextAlign = ContentAlignment.MiddleCenter; //gia na
            lbl.AutoSize = false; // menei katw
            lbl.Width = icon.Width; // apo thn eikona
            lbl.Height = 40;
            this.Controls.Add(icon);
            this.Controls.Add(lbl);
            target.Dock = DockStyle.Fill;
            this.Tag = target;
            this.Margin = new Padding(10);
        }

    }
}
