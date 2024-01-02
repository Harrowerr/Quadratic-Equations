using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuadraticEquationSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double disc, deno, x1, x2;
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);
            c = Convert.ToDouble(txt3.Text);
            if (a == 0)
            {
                x1 = -c / b;
                label7.Text = x1.ToString();
                label8.Text = x1.ToString();
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;
                if (disc > 0)
                {
                    
                    label7.Text = ((-b / deno) + (Math.Sqrt(disc) / deno)).ToString();
                    label8.Text = ((-b / deno) - (Math.Sqrt(disc) / deno)).ToString();
                }
                else if (disc == 0)
                {
                    
                    x1 = -b / deno;

                    label7.Text = x1.ToString();
                    label8.Text = x1.ToString();
                }
                else
                {
                    
                    x1 = -b / deno;
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    label7.Text=( x1 + " +i " + x2);
                    label8.Text=(x1 + " -i " + x2);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }
    }
}
