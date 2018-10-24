namespace Inventory_Manager
{
    partial class addInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addInventory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventoryAddSKUTextbox = new System.Windows.Forms.Label();
            this.unitAddTextbox = new System.Windows.Forms.Label();
            this.inventoryAddNameTextBox = new System.Windows.Forms.Label();
            this.addUnitTextBox = new System.Windows.Forms.TextBox();
            this.addInventorySKUTextBox = new System.Windows.Forms.TextBox();
            this.addInventoryTextBox = new System.Windows.Forms.TextBox();
            this.inventroyListClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addInventoryNExitButton = new Inventory_Manager.customButton();
            this.addInventoryButton = new Inventory_Manager.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventroyListClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 242);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inventoryAddSKUTextbox
            // 
            this.inventoryAddSKUTextbox.AutoSize = true;
            this.inventoryAddSKUTextbox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryAddSKUTextbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.inventoryAddSKUTextbox.Location = new System.Drawing.Point(11, 375);
            this.inventoryAddSKUTextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryAddSKUTextbox.Name = "inventoryAddSKUTextbox";
            this.inventoryAddSKUTextbox.Size = new System.Drawing.Size(120, 19);
            this.inventoryAddSKUTextbox.TabIndex = 17;
            this.inventoryAddSKUTextbox.Text = "Inventory SKU";
            // 
            // unitAddTextbox
            // 
            this.unitAddTextbox.AutoSize = true;
            this.unitAddTextbox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitAddTextbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.unitAddTextbox.Location = new System.Drawing.Point(11, 407);
            this.unitAddTextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitAddTextbox.Name = "unitAddTextbox";
            this.unitAddTextbox.Size = new System.Drawing.Size(41, 19);
            this.unitAddTextbox.TabIndex = 16;
            this.unitAddTextbox.Text = "Unit";
            // 
            // inventoryAddNameTextBox
            // 
            this.inventoryAddNameTextBox.AutoSize = true;
            this.inventoryAddNameTextBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryAddNameTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.inventoryAddNameTextBox.Location = new System.Drawing.Point(11, 343);
            this.inventoryAddNameTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryAddNameTextBox.Name = "inventoryAddNameTextBox";
            this.inventoryAddNameTextBox.Size = new System.Drawing.Size(81, 19);
            this.inventoryAddNameTextBox.TabIndex = 15;
            this.inventoryAddNameTextBox.Text = "Inventory";
            // 
            // addUnitTextBox
            // 
            this.addUnitTextBox.Location = new System.Drawing.Point(141, 404);
            this.addUnitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addUnitTextBox.Name = "addUnitTextBox";
            this.addUnitTextBox.Size = new System.Drawing.Size(184, 22);
            this.addUnitTextBox.TabIndex = 14;
            // 
            // addInventorySKUTextBox
            // 
            this.addInventorySKUTextBox.Location = new System.Drawing.Point(141, 372);
            this.addInventorySKUTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addInventorySKUTextBox.Name = "addInventorySKUTextBox";
            this.addInventorySKUTextBox.Size = new System.Drawing.Size(184, 22);
            this.addInventorySKUTextBox.TabIndex = 13;
            // 
            // addInventoryTextBox
            // 
            this.addInventoryTextBox.Location = new System.Drawing.Point(141, 340);
            this.addInventoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addInventoryTextBox.Name = "addInventoryTextBox";
            this.addInventoryTextBox.Size = new System.Drawing.Size(184, 22);
            this.addInventoryTextBox.TabIndex = 12;
            // 
            // addInventoryNExitButton
            // 
            this.addInventoryNExitButton.ButtonText = "   Add and Exit";
            this.addInventoryNExitButton.Location = new System.Drawing.Point(199, 459);
            this.addInventoryNExitButton.Margin = new System.Windows.Forms.Padding(5);
            this.addInventoryNExitButton.Name = "addInventoryNExitButton";
            this.addInventoryNExitButton.Size = new System.Drawing.Size(115, 28);
            this.addInventoryNExitButton.TabIndex = 19;
            this.addInventoryNExitButton.Click += new System.EventHandler(this.addInventoryNExitButton_Click);
            // 
            // addInventoryButton
            // 
            this.addInventoryButton.ButtonText = "          Add";
            this.addInventoryButton.Location = new System.Drawing.Point(20, 459);
            this.addInventoryButton.Margin = new System.Windows.Forms.Padding(5);
            this.addInventoryButton.Name = "addInventoryButton";
            this.addInventoryButton.Size = new System.Drawing.Size(115, 28);
            this.addInventoryButton.TabIndex = 18;
            this.addInventoryButton.Click += new System.EventHandler(this.addInventoryButton_Click);
            this.addInventoryButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addInventoryButton_KeyDown);
            // 
            // addInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 580);
            this.Controls.Add(this.addInventoryNExitButton);
            this.Controls.Add(this.addInventoryButton);
            this.Controls.Add(this.inventoryAddSKUTextbox);
            this.Controls.Add(this.unitAddTextbox);
            this.Controls.Add(this.inventoryAddNameTextBox);
            this.Controls.Add(this.addUnitTextBox);
            this.Controls.Add(this.addInventorySKUTextBox);
            this.Controls.Add(this.addInventoryTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addInventory";
            this.Text = "Add Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addInventory_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventroyListClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private customButton addInventoryNExitButton;
        private customButton addInventoryButton;
        private System.Windows.Forms.Label inventoryAddSKUTextbox;
        private System.Windows.Forms.Label unitAddTextbox;
        private System.Windows.Forms.Label inventoryAddNameTextBox;
        public System.Windows.Forms.TextBox addUnitTextBox;
        public System.Windows.Forms.TextBox addInventorySKUTextBox;
        public System.Windows.Forms.TextBox addInventoryTextBox;
        private System.Windows.Forms.BindingSource inventroyListClassBindingSource;
    }
}