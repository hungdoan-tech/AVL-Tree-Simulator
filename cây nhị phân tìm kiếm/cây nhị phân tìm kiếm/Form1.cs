using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cây_nhị_phân_tìm_kiếm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x1, x2, y1, t1, t2, y2;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Top < this.Height - 100)
                label1.Top += +6;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < this.Width - 100)
                label1.Left += 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Size = new Size(67, 53);
            label1.Location = new Point(x1, y1);
            label1.Tag = box1.Text;
            label1.Text = box1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = this.Width / 2;
            x2 = 15;
            y1 = 15;
            y2 = this.Height / 2;

        }
    }

}
