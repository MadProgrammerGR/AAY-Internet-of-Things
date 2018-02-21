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
    public partial class Calendar : UserControl
    {
        private Dictionary<DateTime, String> notes = new Dictionary<DateTime, string>();
        public Calendar()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            richTextBox1.Text = notes.ContainsKey(e.Start) ? notes[e.Start] : "";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selected = monthCalendar1.SelectionStart;
            if (richTextBox1.Text.Trim() != ""){
                notes[selected] = richTextBox1.Text;
                List<DateTime> bolds = new List<DateTime>(monthCalendar1.BoldedDates);
                bolds.Add(selected);
                monthCalendar1.BoldedDates = bolds.ToArray();
                MessageBox.Show("Επιτυχής αποθήκευση.");
            }else if (notes.ContainsKey(selected)) notes.Remove(selected);
        }
    }
}
