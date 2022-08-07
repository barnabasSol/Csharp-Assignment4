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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form opened = this.ActiveMdiChild;
            if (opened != null)
            {
            opened.Close();
            }
            Form screen = new Form2();
            screen.MdiParent = this;
            screen.Show();
        }

        private void displayProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form opened = this.ActiveMdiChild;
            if (opened != null)
            {
                opened.Close();
            }
            Form ff = new Form3();
            ff.MdiParent = this;
            ff.Show();
            
        }
    }
}
