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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append("mailto:tariqul.shuvo@gmail.com");
            Process.Start(sb.ToString());
        }

        private void about_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
