using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x1, x2, y1, t1, t2, y2;

        

      

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
            x1 = this.Width / 2;
            x2 = 15;
            y1 = 15;
            y2 = this.Height / 2;

           



        }
       
        public void button1_Click(object sender, EventArgs e)
        {
          
     
            l1.Size = new Size(67, 53);
            l1.Location = new Point(x1, y1);
            l1.Tag = box1.Text;
            l1.Text = box1.Text;
            l.Size = new Size(67, 53);
            l.Location = new Point(x1, y1);
            l.Tag = box1.Text;
            l.Text = box1.Text;

            SolidBrush sb = new SolidBrush(Color.Violet);
            Graphics g = this.CreateGraphics();
            g.FillEllipse(sb, 300,20 , 50, 50);
            
            sb.Dispose();
            g.Dispose();

            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (l1.Left < this.Width - 100)
                l1.Left += 5;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (l1.Top < this.Height - 100)
                l1.Top += +6;
        }

    }
}
