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
    public partial class Wardrobe : Form
    {
        //backup array gia na kanw hide ta items efoson den exoun visible property 
        private ListViewItem[] allItems; 
        public Wardrobe()
        {
            InitializeComponent();
            addClothes();
            comboBox1.SelectedIndex = 0;
        }

        private void addClothes()
        {
            add(1, "gray sweatpants ", "<Casual>", Color.LightGray);
            add(1, "working uniform", "<Work>", Color.WhiteSmoke);
            add(2, "blue dress", "<Party>", Color.LightSkyBlue);
            add(2, "jean short 2", "<Casual>", Color.DodgerBlue);
            add(3, "green t-shirt", "<Beach><Casual>", Color.LimeGreen);
            add(4, "black t-shirt 2", "<Beach><Party>", Color.DimGray);
            add(1, "jean short", "<Casual>", Color.AliceBlue);
            add(2, "red t-shirt", "<Beach><Casual>", Color.OrangeRed);
            add(3, "white t-shirt 2", "<Beach><Party>", Color.WhiteSmoke);
            add(2, "jean 2", "<Casual><Party>", Color.LightSteelBlue);
            add(2, "gray sweatpants 2", "<Casual>", Color.LightGray);
            add(1, "old working uniform", "<Work>", Color.WhiteSmoke);
            add(2, "white suit", "<Work><Party>", Color.WhiteSmoke);
            add(2, "blue dress", "<Party>", Color.LightSkyBlue);
            add(2, "swimsuit", "<Beach>", Color.OrangeRed);
            add(3, "white t-shirt", "<Beach><Party>", Color.WhiteSmoke);
            add(2, "jean", "<Casual><Party>", Color.LightSteelBlue);
            add(3, "black t-shirt", "<Beach><Party>", Color.DimGray);
            add(1, "black suit", "<Work><Party>", Color.DimGray);
            allItems = new ListViewItem[listView1.Items.Count];
            listView1.Items.CopyTo(allItems, 0);
        }

        private void add(int quantity, string desc, string tags, Color c)
        {
            ListViewItem item = new ListViewItem(new string[] {"",
                quantity.ToString(), desc, tags}, -1, Color.Empty, c, null);
            listView1.Items.Add(item);
        }

        private void removeSelection(object sender, MouseEventArgs e)
        {
            pictureBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (comboBox1.Text == "All")
                listView1.Items.AddRange(allItems);
            else
                foreach (ListViewItem item in allItems)
                    if (item.SubItems[3].Text.Contains("<" + comboBox1.Text + ">"))
                        listView1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            listView1.Items.Clear();
            Color c1 = colorDialog1.Color;
            foreach (ListViewItem item in allItems){
                Color c2 = item.BackColor;
                double diff = Math.Abs(c1.R-c2.R) + Math.Abs(c1.G-c2.G) + Math.Abs(c1.B-c2.B);
                if (c1.GetBrightness() < 0.1 && c2.GetBrightness() < 0.1
                    || c1.GetBrightness() > 0.9 && c2.GetBrightness() > 0.9
                    || diff < 100)
                    listView1.Items.Add(item);
            }
        }
    }
}
