namespace AAY_Internet_Of_Things
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.fridge = new System.Windows.Forms.PictureBox();
            this.bulb = new System.Windows.Forms.PictureBox();
            this.wardrobe = new System.Windows.Forms.PictureBox();
            this.heating = new System.Windows.Forms.PictureBox();
            this.tv = new System.Windows.Forms.PictureBox();
            this.radio = new System.Windows.Forms.PictureBox();
            this.house = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fridge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardrobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio)).BeginInit();
            this.house.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fridge
            // 
            this.fridge.BackColor = System.Drawing.Color.Transparent;
            this.fridge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fridge.Image = ((System.Drawing.Image)(resources.GetObject("fridge.Image")));
            this.fridge.Location = new System.Drawing.Point(462, 317);
            this.fridge.Name = "fridge";
            this.fridge.Size = new System.Drawing.Size(105, 120);
            this.fridge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fridge.TabIndex = 1;
            this.fridge.TabStop = false;
            this.toolTip1.SetToolTip(this.fridge, "Fridge (Alt+5)");
            this.fridge.Click += new System.EventHandler(this.fridge_Click);
            this.fridge.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.fridge.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // bulb
            // 
            this.bulb.BackColor = System.Drawing.Color.Transparent;
            this.bulb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bulb.Image = ((System.Drawing.Image)(resources.GetObject("bulb.Image")));
            this.bulb.Location = new System.Drawing.Point(175, 147);
            this.bulb.Name = "bulb";
            this.bulb.Size = new System.Drawing.Size(105, 120);
            this.bulb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulb.TabIndex = 2;
            this.bulb.TabStop = false;
            this.toolTip1.SetToolTip(this.bulb, "Lights (Alt+2)");
            this.bulb.Click += new System.EventHandler(this.bulb_Click);
            this.bulb.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.bulb.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // wardrobe
            // 
            this.wardrobe.BackColor = System.Drawing.Color.Transparent;
            this.wardrobe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wardrobe.Image = ((System.Drawing.Image)(resources.GetObject("wardrobe.Image")));
            this.wardrobe.Location = new System.Drawing.Point(637, 54);
            this.wardrobe.Name = "wardrobe";
            this.wardrobe.Size = new System.Drawing.Size(117, 137);
            this.wardrobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wardrobe.TabIndex = 3;
            this.wardrobe.TabStop = false;
            this.toolTip1.SetToolTip(this.wardrobe, "Wardrobe (Alt+6)");
            this.wardrobe.Click += new System.EventHandler(this.wardrobe_Click);
            this.wardrobe.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.wardrobe.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // heating
            // 
            this.heating.BackColor = System.Drawing.Color.Transparent;
            this.heating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.heating.Image = ((System.Drawing.Image)(resources.GetObject("heating.Image")));
            this.heating.Location = new System.Drawing.Point(0, 243);
            this.heating.Name = "heating";
            this.heating.Size = new System.Drawing.Size(88, 93);
            this.heating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heating.TabIndex = 4;
            this.heating.TabStop = false;
            this.toolTip1.SetToolTip(this.heating, "Heating (Alt+1)");
            this.heating.Click += new System.EventHandler(this.heating_Click);
            this.heating.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.heating.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // tv
            // 
            this.tv.BackColor = System.Drawing.Color.Transparent;
            this.tv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tv.Image = ((System.Drawing.Image)(resources.GetObject("tv.Image")));
            this.tv.Location = new System.Drawing.Point(314, 33);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(85, 77);
            this.tv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tv.TabIndex = 5;
            this.tv.TabStop = false;
            this.toolTip1.SetToolTip(this.tv, "TV (Alt+3)");
            this.tv.Click += new System.EventHandler(this.tv_Click);
            this.tv.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.tv.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // radio
            // 
            this.radio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio.BackColor = System.Drawing.Color.Transparent;
            this.radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio.Image = ((System.Drawing.Image)(resources.GetObject("radio.Image")));
            this.radio.Location = new System.Drawing.Point(347, 157);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(116, 86);
            this.radio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.radio.TabIndex = 6;
            this.radio.TabStop = false;
            this.toolTip1.SetToolTip(this.radio, "Radio (Alt+4)");
            this.radio.Click += new System.EventHandler(this.radio_Click);
            this.radio.MouseEnter += new System.EventHandler(this.item_MouseEnter);
            this.radio.MouseLeave += new System.EventHandler(this.item_MouseLeave);
            // 
            // house
            // 
            this.house.BackColor = System.Drawing.Color.Transparent;
            this.house.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("house.BackgroundImage")));
            this.house.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.house.Controls.Add(this.bulb);
            this.house.Controls.Add(this.fridge);
            this.house.Controls.Add(this.radio);
            this.house.Controls.Add(this.tv);
            this.house.Controls.Add(this.heating);
            this.house.Controls.Add(this.wardrobe);
            this.house.Location = new System.Drawing.Point(12, 43);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(820, 498);
            this.house.TabIndex = 7;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 3000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 559);
            this.Controls.Add(this.house);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet of Things - Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fridge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardrobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio)).EndInit();
            this.house.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox fridge;
        private System.Windows.Forms.PictureBox bulb;
        private System.Windows.Forms.PictureBox wardrobe;
        private System.Windows.Forms.PictureBox heating;
        private System.Windows.Forms.PictureBox tv;
        private System.Windows.Forms.PictureBox radio;
        private System.Windows.Forms.Panel house;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}