using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        int[] arrInt = { 2, 3, 6, 4, 7 };
        int i, sum = 0;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //Size s = new Size(100, 100);
            //Rectangle rect = new Rectangle(ClientRectangle.Width / 2 - 50, ClientRectangle.Height / 2 - 50, s.Width, s.Height);
            //Pen p = new Pen(Color.FromArgb(255, 0, 0));           
            //g.DrawEllipse(p, rect);
            //p.Dispose();
            //g.Dispose();
            sample n = new sample();
            n.name1 = "harsh";
            n.address = "new delhi";
            string info = n.GetInfo();
            textBox1.Text = info;

        }
    }
}
