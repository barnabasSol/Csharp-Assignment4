using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applyCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(fnametxt.Text, lnametxt.Text,
                nationalitytxt.Text, dateTimePicker1.Value.ToString("dd-mm-yyyy"), addresstxt.Text);
            c.addCustomer();
            MessageBox.Show("customer: "+c.first_name+" "+c.last_name+" succesfully added!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
