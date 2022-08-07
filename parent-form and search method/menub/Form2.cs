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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.name = textBox1.Text;
            p.price = Convert.ToDouble(textBox2.Text);
            p.count = int.Parse(textBox3.Text);
            p.type = textBox4.Text;

            p.addproduct(p);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.get_products();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Product.get_srch_rslt().Clear();
            Product rslt = Product.find_one(textBox5.Text);
            Product.add_search_result(rslt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.get_srch_rslt();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.get_products();
        }
    }
}
