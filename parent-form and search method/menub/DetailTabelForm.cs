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
    public partial class DetailTabelForm : Form
    {
        public DetailTabelForm()
        {
            InitializeComponent();
        }
        private string _name { get; set; }
        private double _price { get; set; }
        private int _count { get; set; }
        private string _type { get; set; }

        public string name
        {
            get { return _name; }
            set { _name = value; ntxt.Text = value; }
        }

        public double price
        {
            get { return _price; }
            set { _price = value; ptxt.Text = value.ToString(); }
        }

        public int count
        {
            get { return _count; }
            set { _count = value; ctxt.Text = value.ToString(); }
        }


        public string type
        {
            get { return _type; }
            set { _type = value; ttxt.Text = value; }
        }

        private void DetailTabelForm_Load(object sender, EventArgs e)
        {


        }
    }
}
