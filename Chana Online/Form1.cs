using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chana_Online
{
    public partial class Form1 : Form
    {
        FormCart fcart = new FormCart();
       

        List<object> cart = new List<object>();

        private void Form1_Load(object sender, EventArgs e)
        {
            fcart.Show();

        }

        public Form1()
        {
            InitializeComponent();

        }

        

        private void button8_Click(object sender, EventArgs e)
        {

        }
        
        private void btnShop_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            FormGrocery f = new FormGrocery(fcart, this);
            f.Show();
        }

        private void btnLiqour_Click(object sender, EventArgs e)
        {
            FormLiqour f = new FormLiqour(fcart, this);
            f.Show();
        }

        private void btnMeat_Click(object sender, EventArgs e)
        {
            FormButchery f = new FormButchery(fcart, this);
            f.Show();
        }


        private void btnCart1_Click(object sender, EventArgs e)
        {
            FormCart f = new FormCart();
            f.Show();
        }
    }
}
