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
    public partial class Recipes : UserControl
    {
        public Recipes()
        {
            InitializeComponent();
            int[] owned = new int[] {0,2,5,6,7,10,11,12,13};
            foreach(int i in owned) checkedListBox1.SetItemCheckState(i, CheckState.Checked);
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = !checkedListBox1.Visible;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            e.NewValue = e.CurrentValue; //de ginetai na kanoun check(mono osa exei to psygeio mesa menoun checked)
        }
    }
}
