using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAY_Internet_Of_Things
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private float ratio = 1.4f;
        private Size prevSize;
        private Point prevLoc;
        private void item_MouseEnter(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            prevSize = new Size(box.Size.Width, box.Size.Height);
            prevLoc = new Point(box.Location.X, box.Location.Y);
            box.Width = (int)(ratio * prevSize.Width);
            box.Height = (int)(ratio * prevSize.Height);
            box.Location = new Point(prevLoc.X + (prevSize.Width - box.Width) / 2, prevLoc.Y + (prevSize.Height - box.Height) / 2);
        }

        private void item_MouseLeave(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.Width = prevSize.Width;
            box.Height = prevSize.Height;
            box.Location = new Point(prevLoc.X, prevLoc.Y);
        }

        private bool lights = false;
        private void bulb_Click(object sender, EventArgs e)
        {
            lights = !lights;
            if (lights) bulb.Image = Properties.Resources.bulb_on;
            else bulb.Image = Properties.Resources.bulb_off;
        }

        private void tv_Click(object sender, EventArgs e)
        {
            new TV().Show();
        }

        private void heating_Click(object sender, EventArgs e)
        {
            new Heating().Show();
        }

        private void radio_Click(object sender, EventArgs e)
        {
            new Radio().Show();
        }

        private void fridge_Click(object sender, EventArgs e)
        {
            new Fridge().Show();
        }

        private void wardrobe_Click(object sender, EventArgs e)
        {
            new Wardrobe().Show();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys key)
        {
            switch (key)
            {
                case (Keys.Alt | Keys.D1):
                    heating_Click(null, null); return true;
                case (Keys.Alt | Keys.D2):
                    bulb_Click(null, null); return true;
                case (Keys.Alt | Keys.D3):
                    tv_Click(null, null); return true;
                case (Keys.Alt | Keys.D4):
                    radio_Click(null, null); return true;
                case (Keys.Alt | Keys.D5):
                    fridge_Click(null, null); return true;
                case (Keys.Alt | Keys.D6):
                    wardrobe_Click(null, null); return true;
            }
            return base.ProcessCmdKey(ref msg, key);
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by:\n\t- Giorgos\n\t- Fanis","About");
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FeedBack().ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "manual.chm", HelpNavigator.TopicId, "30");
        }

    }
}
