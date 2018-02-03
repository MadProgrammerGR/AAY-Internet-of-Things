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
    public partial class Radio : Form
    {
        public Radio()
        {
            InitializeComponent();
        }

        private bool active = false;
        private void button1_Click(object sender, EventArgs e)
        {
            active = !active;
            if (active) button1.Text = "Stop";
            else button1.Text = "Start";
            foreach (Control c in panel1.Controls) c.Enabled = active;
            button1.Enabled = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = (trackBar1.Value/10f).ToString();
        }
    }
}
