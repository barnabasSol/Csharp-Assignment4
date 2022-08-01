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


        private void addbtn_Click(object sender, EventArgs e)
        {
            bool allCorrect = true;
            Customer cc = new Customer();
            if (string.IsNullOrEmpty(fnametxt.Text) || int.TryParse(lnametxt.Text, out int num1))
            {
                errorProvider1.SetError(fnametxt, "something wrong here");
                allCorrect = false;

            }
            if (string.IsNullOrEmpty(lnametxt.Text) || int.TryParse(lnametxt.Text, out int num2))
            {
                errorProvider1.SetError(lnametxt, "something wrong here");
                allCorrect = false;

            }
            if (!int.TryParse(agetxt.Text, out int num3))
            {
                errorProvider1.SetError(agetxt, "something wrong here");
                allCorrect = false;
            }
            if (string.IsNullOrEmpty(dateTimePicker1.Value.ToString("dd/mm/yyyy"))){
                errorProvider1.SetError(dateTimePicker1, "something wrong here");
            }
            if (string.IsNullOrEmpty(fnametxt.Text))
            {
                errorProvider1.SetError(nationalitytxt, "something wrong here");
                allCorrect = false;
            }
            if (string.IsNullOrEmpty(addresstxt.Text))
            {
                errorProvider1.SetError(addresstxt, "something wrong here");
                allCorrect = false;
            }
            if (allCorrect)
            {
                cc.first_name = fnametxt.Text;
                cc.last_name = lnametxt.Text;
                cc.age = int.Parse(agetxt.Text);
                cc.nationality = nationalitytxt.Text;
                cc.birth_date = dateTimePicker1.Value.ToString("dd/mm/yyyy");
                cc.address = addresstxt.Text;
                cc.male = malebox.Checked;
                cc.female = femalbox.Checked;
                cc.addCustomer(cc);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Customer.get_customer_list();
            }
            // MessageBox.Show("successful added!");
        }

      
    }
}
