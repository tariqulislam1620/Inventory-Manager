using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Manager
{
    public partial class addInventory : Form
    {
        public addInventory()
        {
            InitializeComponent();
        }

        private void addInventoryButton_Click(object sender, EventArgs e)
        {
            con("INSERT INTO inventory_lists_tbl VALUES ('" +addInventoryTextBox.Text+ "', '" +addInventorySKUTextBox.Text+ "', '" +addUnitTextBox.Text+ "')");
        }

        private void addInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void addInventoryNExitButton_Click(object sender, EventArgs e)
        {
            con("INSERT INTO inventory_lists_tbl VALUES ('" + addInventoryTextBox.Text + "', '" + addInventorySKUTextBox.Text + "', '" + addUnitTextBox.Text + "')");
            this.Hide();
            mainLayout mL = new mainLayout();
            mL.Show();
        }

        private void con(string q)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=localhost;Initial Catalog=invertory_DB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand(q, sqlcon);
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                MessageBox.Show("Inventory added successfully", "Inventory Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show("Inventory is already added. Update it as In Inventory", "Inventroy Already Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addInventoryButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) con("INSERT INTO inventory_lists_tbl VALUES ('" + addInventoryTextBox.Text + "', '" + addInventorySKUTextBox.Text + "', '" + addUnitTextBox.Text + "')");
        }
    }
}
