using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AAY_Internet_Of_Things.fridgeapps;

namespace AAY_Internet_Of_Things
{
    public partial class Fridge : Form
    {
        bool active;
        public Fridge()
        {
            InitializeComponent();
            active = false;
            panel1.BackColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            active = !active;
            if (active)
            {
                //Close screen
                panel1.Controls.Clear();
                panel1.BackColor = Color.Black;
            }
            else
            {
                //open screen
                panel1.Controls.Clear();
                panel1.Controls.Add(new fridgeapps.home());
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            App.go_back(panel1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            App.open_app(new fridgeapps.menu(),panel1);
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            App.open_app(new fridgeapps.home(),panel1);
        }

        
    }
}
