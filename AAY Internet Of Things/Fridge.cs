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
    public partial class Fridge : Form
    {
        private bool active = false;
        private Stack<UserControl> history = new Stack<UserControl>();
        public Fridge()
        {
            InitializeComponent();
        }

        //on/off koumpi
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            active = !active;
            if (active) pictureBox5_Click(null, null); //home koumpi
            else panel1.Controls.Clear();
            pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = active;
        }

        //back koumpi
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (history.Count != 0){
                panel1.Controls.Clear();
                panel1.Controls.Add(history.Pop());
            }
        }

        //menu koumpi
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UserControl m = new FridgeApps.Menu();
            history.Push(m);
            panel1.Controls.Clear();
            panel1.Controls.Add(m);
        }

        //home koumpi
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            UserControl h = new FridgeApps.Home();
            history.Push(h);
            panel1.Controls.Clear();
            panel1.Controls.Add(h);
        }
        
    }

}
