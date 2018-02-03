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
    public partial class TV : Form
    {
        public TV()
        {
            InitializeComponent();
        }

        bool active = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            active = !active;
            if (active)
            {
                pictureBox2.Image = Properties.Resources.button_on;
                panel2.Show();
                label1.Show();
                label2.Show();
            }
            else
            {
                pictureBox2.Image = Properties.Resources.button_of;
                panel2.Hide();
                label1.Hide();
                label2.Hide();
            }
        }

        private int channel = 1;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!active) { MessageBox.Show("Please turn on the tv first.", "TV status"); return; }
            channel++;
            label1.Text = "Channel: " + channel;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!active) { MessageBox.Show("Please turn on the tv first.", "TV status"); return; }
            channel--;
            label1.Text = "Channel: " + channel;
        }

        private int volume = 50;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!active) { MessageBox.Show("Please turn on the tv first.", "TV status"); return; }
            volume++;
            label2.Text = "Volume: " + volume;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!active) { MessageBox.Show("Please turn on the tv first.", "TV status"); return; }
            volume--;
            label2.Text = "Volume: " + volume;
        }
    }
}
