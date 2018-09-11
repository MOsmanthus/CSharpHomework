using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            double m = 0;
            double n = 0;
            double p = 0;
            s = textBox1.Text;
            m = double.Parse(s);
            s = textBox2.Text;
            n = double.Parse(s);
            p = m * n;
            label3.Text = "Product of two numbers is : " + p;
        }
    }
}
