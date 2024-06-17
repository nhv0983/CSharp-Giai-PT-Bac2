using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Giai_PT_Bac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txta.Text = trackBar1.Value.ToString();

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            txtc.Text = trackBar3.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtb.Text = trackBar2.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = Convert.ToInt32(txtc.Text);
            double delta, x1, x2;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c != 0) { lblkq.Text = "pt vo nghiem"; }
                    else { lblkq.Text = "pt co vo so nghiem"; }
                }
                else
                {
                    x1 = x2 = -c / 3;
                    lblkq.Text = "pt co nghiem x=" + x1;
                }

            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    lblkq.Text = "pt vo nghiem";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    lblkq.Text = "pt co nghiem kep x1=x2=";
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    lblkq.Text = "pt co 2 nghiem phan bien\n";
                }
            }
        }
    }
}
        
    

