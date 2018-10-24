using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Inventory_Manager
{
    public partial class mainLayout : Form
    {
        public mainLayout()
        {
            InitializeComponent();
        }

        addInventory addI = new addInventory();
        inventoryIn inI = new inventoryIn();
        inventoryOut inO = new inventoryOut();
        listInverntory inL = new listInverntory();
        about a = new about();
       

        private void addInventoryButton_Click(object sender, EventArgs e)
        { addI.Show(); this.Hide(); }

        private void addInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        { addI.Show(); }

        private void inventoryInToolStripMenuItem_Click(object sender, EventArgs e)
        { inI.Show(); }

        private void inventoryInButton_Click(object sender, EventArgs e)
        { inI.Show(); }

        private void inventoryOutToolStripMenuItem_Click(object sender, EventArgs e)
        { inO.Show(); }

        private void inventoryOutButton_Click(object sender, EventArgs e)
        { inO.Show(); }

        private void inventoryListToolStripMenuItem_Click(object sender, EventArgs e)
        { inL.Show(); }

        private void inventoryListButton_Click(object sender, EventArgs e)
        { inL.Show(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { Process.GetCurrentProcess().Kill(); }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        { a.Show(); }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No update is available right now.\r\nStay connected and Check later for updates", "Update not available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mainLayout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
