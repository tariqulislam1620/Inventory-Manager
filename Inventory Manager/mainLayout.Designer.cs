namespace Inventory_Manager
{
    partial class mainLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainLayout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolTripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryReportButton = new Inventory_Manager.customButton();
            this.inventoryListButton = new Inventory_Manager.customButton();
            this.inventoryInButton = new Inventory_Manager.customButtonTwo();
            this.inventoryOutButton = new Inventory_Manager.customButtonTwo();
            this.addInventoryButton = new Inventory_Manager.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 270);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolTripButton,
            this.helpToolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(345, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolTripButton
            // 
            this.fileToolTripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInventoryToolStripMenuItem,
            this.updateInventoryToolStripMenuItem,
            this.inventoryListToolStripMenuItem,
            this.exportReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolTripButton.Image = ((System.Drawing.Image)(resources.GetObject("fileToolTripButton.Image")));
            this.fileToolTripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolTripButton.Name = "fileToolTripButton";
            this.fileToolTripButton.Size = new System.Drawing.Size(66, 24);
            this.fileToolTripButton.Text = "File";
            // 
            // addInventoryToolStripMenuItem
            // 
            this.addInventoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addInventoryToolStripMenuItem.Image")));
            this.addInventoryToolStripMenuItem.Name = "addInventoryToolStripMenuItem";
            this.addInventoryToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.addInventoryToolStripMenuItem.Text = "Add Inventory";
            this.addInventoryToolStripMenuItem.Click += new System.EventHandler(this.addInventoryToolStripMenuItem_Click);
            // 
            // updateInventoryToolStripMenuItem
            // 
            this.updateInventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryInToolStripMenuItem,
            this.inventoryOutToolStripMenuItem});
            this.updateInventoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateInventoryToolStripMenuItem.Image")));
            this.updateInventoryToolStripMenuItem.Name = "updateInventoryToolStripMenuItem";
            this.updateInventoryToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.updateInventoryToolStripMenuItem.Text = "Update Inventory";
            // 
            // inventoryInToolStripMenuItem
            // 
            this.inventoryInToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryInToolStripMenuItem.Image")));
            this.inventoryInToolStripMenuItem.Name = "inventoryInToolStripMenuItem";
            this.inventoryInToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.inventoryInToolStripMenuItem.Text = "Inventory In";
            this.inventoryInToolStripMenuItem.Click += new System.EventHandler(this.inventoryInToolStripMenuItem_Click);
            // 
            // inventoryOutToolStripMenuItem
            // 
            this.inventoryOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryOutToolStripMenuItem.Image")));
            this.inventoryOutToolStripMenuItem.Name = "inventoryOutToolStripMenuItem";
            this.inventoryOutToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.inventoryOutToolStripMenuItem.Text = "Inventory Out";
            this.inventoryOutToolStripMenuItem.Click += new System.EventHandler(this.inventoryOutToolStripMenuItem_Click);
            // 
            // inventoryListToolStripMenuItem
            // 
            this.inventoryListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryListToolStripMenuItem.Image")));
            this.inventoryListToolStripMenuItem.Name = "inventoryListToolStripMenuItem";
            this.inventoryListToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.inventoryListToolStripMenuItem.Text = "Inventory List";
            this.inventoryListToolStripMenuItem.Click += new System.EventHandler(this.inventoryListToolStripMenuItem_Click);
            // 
            // exportReportToolStripMenuItem
            // 
            this.exportReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportReportToolStripMenuItem.Image")));
            this.exportReportToolStripMenuItem.Name = "exportReportToolStripMenuItem";
            this.exportReportToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.exportReportToolStripMenuItem.Text = "Export Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripDropDownButton1
            // 
            this.helpToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem});
            this.helpToolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripDropDownButton1.Image")));
            this.helpToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripDropDownButton1.Name = "helpToolStripDropDownButton1";
            this.helpToolStripDropDownButton1.Size = new System.Drawing.Size(75, 24);
            this.helpToolStripDropDownButton1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checkForUpdateToolStripMenuItem.Image")));
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.checkForUpdateToolStripMenuItem.Text = "Check for Update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // inventoryReportButton
            // 
            this.inventoryReportButton.ButtonText = "Inventory Report";
            this.inventoryReportButton.Location = new System.Drawing.Point(37, 514);
            this.inventoryReportButton.Margin = new System.Windows.Forms.Padding(5);
            this.inventoryReportButton.Name = "inventoryReportButton";
            this.inventoryReportButton.Size = new System.Drawing.Size(267, 42);
            this.inventoryReportButton.TabIndex = 5;
            // 
            // inventoryListButton
            // 
            this.inventoryListButton.ButtonText = "   Inventory List";
            this.inventoryListButton.Location = new System.Drawing.Point(37, 454);
            this.inventoryListButton.Margin = new System.Windows.Forms.Padding(5);
            this.inventoryListButton.Name = "inventoryListButton";
            this.inventoryListButton.Size = new System.Drawing.Size(267, 42);
            this.inventoryListButton.TabIndex = 4;
            this.inventoryListButton.Click += new System.EventHandler(this.inventoryListButton_Click);
            // 
            // inventoryInButton
            // 
            this.inventoryInButton.ButtonText = "    Inventory In";
            this.inventoryInButton.Location = new System.Drawing.Point(37, 407);
            this.inventoryInButton.Margin = new System.Windows.Forms.Padding(5);
            this.inventoryInButton.Name = "inventoryInButton";
            this.inventoryInButton.Size = new System.Drawing.Size(115, 31);
            this.inventoryInButton.TabIndex = 3;
            this.inventoryInButton.Click += new System.EventHandler(this.inventoryInButton_Click);
            // 
            // inventoryOutButton
            // 
            this.inventoryOutButton.ButtonText = "   Inventory Out";
            this.inventoryOutButton.Location = new System.Drawing.Point(193, 407);
            this.inventoryOutButton.Margin = new System.Windows.Forms.Padding(5);
            this.inventoryOutButton.Name = "inventoryOutButton";
            this.inventoryOutButton.Size = new System.Drawing.Size(111, 31);
            this.inventoryOutButton.TabIndex = 2;
            this.inventoryOutButton.Click += new System.EventHandler(this.inventoryOutButton_Click);
            // 
            // addInventoryButton
            // 
            this.addInventoryButton.ButtonText = "  Add Inventory";
            this.addInventoryButton.Location = new System.Drawing.Point(37, 343);
            this.addInventoryButton.Margin = new System.Windows.Forms.Padding(5);
            this.addInventoryButton.Name = "addInventoryButton";
            this.addInventoryButton.Size = new System.Drawing.Size(267, 42);
            this.addInventoryButton.TabIndex = 0;
            this.addInventoryButton.Click += new System.EventHandler(this.addInventoryButton_Click);
            // 
            // mainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 580);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inventoryReportButton);
            this.Controls.Add(this.inventoryListButton);
            this.Controls.Add(this.inventoryInButton);
            this.Controls.Add(this.inventoryOutButton);
            this.Controls.Add(this.addInventoryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainLayout";
            this.Text = "Inventory Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainLayout_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customButton addInventoryButton;
        private customButtonTwo inventoryOutButton;
        private customButtonTwo inventoryInButton;
        private customButton inventoryListButton;
        private customButton inventoryReportButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileToolTripButton;
        private System.Windows.Forms.ToolStripMenuItem addInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton helpToolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryListToolStripMenuItem;
    }
}

