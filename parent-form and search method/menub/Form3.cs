using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menub
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.get_products();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1[] u = new UserControl1[Product.get_products().Count];
            for (int i = 0; i < Product.get_products().Count; i++)
            {
                u[i] = new UserControl1();
                u[i].name = Product.get_products()[i].name;
                u[i].price = Product.get_products()[i].price;
                u[i].count = Product.get_products()[i].count;
                u[i].type = Product.get_products()[i].type;
                flowLayoutPanel1.Controls.Add(u[i]);
            }
        }
    }
}
