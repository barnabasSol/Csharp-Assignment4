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

            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < Product.get_products().Count; i++)
            {
                UserControl1 itemc = new UserControl1();
                itemc.name = Product.get_products()[i].name;
                itemc.price = Product.get_products()[i].price;
                itemc.count = Product.get_products()[i].count;
                itemc.type = Product.get_products()[i].type;
                itemc.Click += (object s, EventArgs ev) =>
                {
                    DetailTabelForm d = new DetailTabelForm();
                    d.name = itemc.name;
                    d.price = itemc.price;
                    d.count = itemc.count;
                    d.type = itemc.type;
                    d.Show();

                };

                flowLayoutPanel1.Controls.Add(itemc);
            }
        }
    }
}
