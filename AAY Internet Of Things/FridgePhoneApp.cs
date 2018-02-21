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
    public partial class FridgePhoneApp : Form
    {
        public FridgePhoneApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = Properties.Resources.fridge_inside;
        }
    }
}
