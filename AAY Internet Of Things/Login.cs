using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AAY_Internet_Of_Things
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            if (username == "user" && password == "pass")
            {
                panel1.Enabled = false;
                panel2.Visible = true;
                new Thread(function).Start(); //wra anamonhs!
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Login Status");
            }
        }

        private void function()
        {
            progress("Connecting with Fridge...", 500, 100 / 6);
            progress("Connecting with Wardrobe...", 500, 100 / 6);
            progress("Connecting with Lights...", 300, 100 / 6);
            progress("Connecting with Heating...", 600, 100 / 6);
            progress("Connecting with Television...", 400, 100 / 6);
            progress("Connecting with Radio...", 400, 100 - progressBar1.Value);
            this.Invoke((MethodInvoker)delegate {
                this.Hide();
                new Home().Show();
            });
        }

        private void progress(String description, int time, int step)
        {
            // to invoke xreiazetai gia na "parei prosvash" sto thread tou UI ths formas
            this.Invoke((MethodInvoker)delegate{label4.Text = description;});
            Thread.Sleep(time); // to sleep prepei na tre3ei sauto to nhma
            this.Invoke((MethodInvoker)delegate{progressBar1.Value += step;});
        }
    }
}
