using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class customButton : UserControl
    {
        public customButton()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawButton(Color.FromArgb(255, 0, 121, 170), Color.FromArgb(255, 0, 71, 120));
        }

        string text = "custom button one";
        public string ButtonText
        {
            get { return text; }
            set { text = value; }
        }

        void DrawButton(Color c, Color bc)
        {
            SolidBrush sb = new SolidBrush(c);
            Graphics g = this.CreateGraphics();
            g.FillEllipse(sb, 0, 0, this.Width, this.Height);
            Pen pen = new Pen(bc, 3);
            g.DrawEllipse(pen, 0, 0, this.Width, this.Height);
            PointF fPoint = new Point((this.Width / 2) - 45, (this.Height / 2) - 7);
            Font f = new Font(new FontFamily("Arial"), 8);
            sb.Color = Color.Black;
            g.DrawString(text, f, sb, fPoint);
        }

        private void customButton_MouseHover(object sender, EventArgs e)
        {
            DrawButton(Color.YellowGreen, Color.Green);
        }

        private void customButton_MouseLeave(object sender, EventArgs e)
        {
            DrawButton(Color.FromArgb(255, 0, 121, 170), Color.FromArgb(255, 0, 71, 120));
        }

        private void customButton_MouseEnter(object sender, EventArgs e)
        {
            DrawButton(Color.YellowGreen, Color.Green);
        }
    }
}
