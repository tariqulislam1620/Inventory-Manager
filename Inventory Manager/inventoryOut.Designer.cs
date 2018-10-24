namespace Inventory_Manager
{
    partial class inventoryOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryOut));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventoryInTextbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.inventoryOutSKUTextbox = new System.Windows.Forms.Label();
            this.unitOutTextbox = new System.Windows.Forms.Label();
            this.inventoryOutNameTextBox = new System.Windows.Forms.Label();
            this.outInventoryNExitButton = new Inventory_Manager.customButton();
            this.outInventoryButton = new Inventory_Manager.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 249);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inventoryInTextbox
            // 
            this.inventoryInTextbox.Location = new System.Drawing.Point(141, 340);
            this.inventoryInTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inventoryInTextbox.Name = "inventoryInTextbox";
            this.inventoryInTextbox.Size = new System.Drawing.Size(184, 22);
            this.inventoryInTextbox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 372);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 404);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 4;
            // 
            // inventoryOutSKUTextbox
            // 
            this.inventoryOutSKUTextbox.AutoSize = true;
            this.inventoryOutSKUTextbox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryOutSKUTextbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.inventoryOutSKUTextbox.Location = new System.Drawing.Point(11, 375);
            this.inventoryOutSKUTextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryOutSKUTextbox.Name = "inventoryOutSKUTextbox";
            this.inventoryOutSKUTextbox.Size = new System.Drawing.Size(120, 19);
            this.inventoryOutSKUTextbox.TabIndex = 9;
            this.inventoryOutSKUTextbox.Text = "Inventory SKU";
            // 
            // unitOutTextbox
            // 
            this.unitOutTextbox.AutoSize = true;
            this.unitOutTextbox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitOutTextbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.unitOutTextbox.Location = new System.Drawing.Point(11, 407);
            this.unitOutTextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitOutTextbox.Name = "unitOutTextbox";
            this.unitOutTextbox.Size = new System.Drawing.Size(73, 19);
            this.unitOutTextbox.TabIndex = 8;
            this.unitOutTextbox.Text = "Unit Out";
            // 
            // inventoryOutNameTextBox
            // 
            this.inventoryOutNameTextBox.AutoSize = true;
            this.inventoryOutNameTextBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryOutNameTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.inventoryOutNameTextBox.Location = new System.Drawing.Point(11, 343);
            this.inventoryOutNameTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryOutNameTextBox.Name = "inventoryOutNameTextBox";
            this.inventoryOutNameTextBox.Size = new System.Drawing.Size(81, 19);
            this.inventoryOutNameTextBox.TabIndex = 7;
            this.inventoryOutNameTextBox.Text = "Inventory";
            // 
            // outInventoryNExitButton
            // 
            this.outInventoryNExitButton.ButtonText = " Out and Exit";
            this.outInventoryNExitButton.Location = new System.Drawing.Point(199, 459);
            this.outInventoryNExitButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.outInventoryNExitButton.Name = "outInventoryNExitButton";
            this.outInventoryNExitButton.Size = new System.Drawing.Size(115, 28);
            this.outInventoryNExitButton.TabIndex = 11;
            // 
            // outInventoryButton
            // 
            this.outInventoryButton.ButtonText = "        Out";
            this.outInventoryButton.Location = new System.Drawing.Point(20, 459);
            this.outInventoryButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.outInventoryButton.Name = "outInventoryButton";
            this.outInventoryButton.Size = new System.Drawing.Size(115, 28);
            this.outInventoryButton.TabIndex = 10;
            // 
            // inventoryOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 580);
            this.Controls.Add(this.outInventoryNExitButton);
            this.Controls.Add(this.outInventoryButton);
            this.Controls.Add(this.inventoryOutSKUTextbox);
            this.Controls.Add(this.unitOutTextbox);
            this.Controls.Add(this.inventoryOutNameTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inventoryInTextbox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "inventoryOut";
            this.Text = "Inventory Out";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inventoryOut_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inventoryInTextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label inventoryOutSKUTextbox;
        private System.Windows.Forms.Label unitOutTextbox;
        private System.Windows.Forms.Label inventoryOutNameTextBox;
        private customButton outInventoryNExitButton;
        private customButton outInventoryButton;
    }
}