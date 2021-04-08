using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kap kap = new Kap();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            kap.Postavi(ClientRectangle.Width / 2, 100, 20);
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kap.Pomeri(5);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            kap.Crtaj(e.Graphics);
            //Flasa
            Graphics g = CreateGraphics();
            int a = ClientRectangle.Height;
            int b = ClientRectangle.Width;
            Pen pen = new Pen(Color.Black, 3);
            Brush brush = new SolidBrush(Color.Black);
            g.DrawRectangle(pen,b/2 - 50, a - 100, 100, 100);
            g.FillRectangle(brush, b / 2 - 50, a - 100, 100, 100);
            g.DrawRectangle(pen, b / 2 - 20, a - 150, 40, 150);
            g.FillRectangle(brush, b / 2 - 20, a - 150, 40, 150);
        }
    }
}
