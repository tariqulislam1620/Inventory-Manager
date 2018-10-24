namespace Inventory_Manager
{
    partial class inventoryIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventoryInTextbox = new System.Windows.Forms.TextBox();
            this.inventoryInNameTextBox = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.unitInTextbox = new System.Windows.Forms.Label();
            this.inventoryInSKUTextbox = new System.Windows.Forms.Label();
            this.inInventoryButton = new Inventory_Manager.customButton();
            this.inInventoryNExitButton = new Inventory_Manager.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inventoryInTextbox
            // 
            this.inventoryInTextbox.Location = new System.Drawing.Point(106, 276);
            this.inventoryInTextbox.Name = "inventoryInTextbox";
            this.inventoryInTextbox.Size = new System.Drawing.Size(139, 20);
            this.inventoryInTextbox.TabIndex = 1;
            // 
            // inventoryInNameTextBox
            // 
            this.inventoryInNameTextBox.AutoSize = true;
            this.inventoryInNameTextBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryInNameTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.inventoryInNameTextBox.Location = new System.Drawing.Point(8, 279);
            this.inventoryInNameTextBox.Name = "inventoryInNameTextBox";
            this.inventoryInNameTextBox.Size = new System.Drawing.Size(64, 15);
            this.inventoryInNameTextBox.TabIndex = 2;
            this.inventoryInNameTextBox.Text = "Inventory";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 302);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 4;
            // 
            // unitInTextbox
            // 
            this.unitInTextbox.AutoSize = true;
            this.unitInTextbox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitInTextbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.unitInTextbox.Location = new System.Drawing.Point(8, 331);
            this.unitInTextbox.Name = "unitInTextbox";
            this.unitInTextbox.Size = new System.Drawing.Size(47, 15);
            this.unitInTextbox.TabIndex = 5;
            this.unitInTextbox.Text = "Unit In";
            // 
            // inventoryInSKUTextbox
            // 
            this.inventoryInSKUTextbox.AutoSize = true;
            this.inventoryInSKUTextbox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryInSKUTextbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.inventoryInSKUTextbox.Location = new System.Drawing.Point(8, 305);
            this.inventoryInSKUTextbox.Name = "inventoryInSKUTextbox";
            this.inventoryInSKUTextbox.Size = new System.Drawing.Size(94, 15);
            this.inventoryInSKUTextbox.TabIndex = 6;
            this.inventoryInSKUTextbox.Text = "Inventory SKU";
            // 
            // inInventoryButton
            // 
            this.inInventoryButton.ButtonText = "            In";
            this.inInventoryButton.Location = new System.Drawing.Point(15, 373);
            this.inInventoryButton.Name = "inInventoryButton";
            this.inInventoryButton.Size = new System.Drawing.Size(86, 23);
            this.inInventoryButton.TabIndex = 7;
            // 
            // inInventoryNExitButton
            // 
            this.inInventoryNExitButton.ButtonText = "     In and Exit";
            this.inInventoryNExitButton.Location = new System.Drawing.Point(149, 373);
            this.inInventoryNExitButton.Name = "inInventoryNExitButton";
            this.inInventoryNExitButton.Size = new System.Drawing.Size(86, 23);
            this.inInventoryNExitButton.TabIndex = 8;
            // 
            // inventoryIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 471);
            this.Controls.Add(this.inInventoryNExitButton);
            this.Controls.Add(this.inInventoryButton);
            this.Controls.Add(this.inventoryInSKUTextbox);
            this.Controls.Add(this.unitInTextbox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.inventoryInNameTextBox);
            this.Controls.Add(this.inventoryInTextbox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inventoryIn";
            this.Text = "Inventory In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inventoryIn_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inventoryInTextbox;
        private System.Windows.Forms.Label inventoryInNameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label unitInTextbox;
        private System.Windows.Forms.Label inventoryInSKUTextbox;
        private customButton inInventoryButton;
        private customButton inInventoryNExitButton;
    }
}