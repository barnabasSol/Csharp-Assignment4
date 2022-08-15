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
    public partial class UserControl1 : UserControl
    {
        private string _name { get; set; }
        private double _price { get; set; }
        private int _count { get; set; }
        private string _type { get; set; }

        public string name
        {
            get { return _name; }
            set { _name = value; label5.Text = value; }
        }

        public double price
        {
            get { return _price; }
            set { _price = value; label6.Text = value.ToString(); }
        }

        public int count
        {
            get { return _count; }
            set { _count = value; label7.Text = value.ToString(); }
        }


        public string type
        {
            get { return _type; }
            set { _type = value; label7.Text = value; }
        }


        public UserControl1()
        {
            InitializeComponent();
        }

        

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
