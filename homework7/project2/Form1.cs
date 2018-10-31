using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project1;

namespace project2
{
    public partial class Form1 : Form
    {
        OrderService temp = new OrderService();
        public static List<Order> orders = new List<Order>();

        public string KeyWord { get; set; }

        public Form1()
        {
            InitializeComponent();
            orderbindingSource.DataSource = orders;
            IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null)
            {
                
            }
            else if (textBox1.Text != null)
            {
                ts = temp.SearchOrder(textBox1.Text);
                orderbindingSource.DataSource = ts;
                label5.Text = Convert.ToString("共" + ts.Count() + "条记录");
            }
            else if (textBox2.Text != null)
            {
                ts = temp.SearchPrice(Convert.ToDouble(textBox2.Text));
                orderbindingSource.DataSource = ts;
            }
        }
    }
}
