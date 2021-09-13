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
            FormGrocery f = new FormGrocery(fcart);
            f.Show();
        }

        private void btnLiqour_Click(object sender, EventArgs e)
        {
            FormLiqour f = new FormLiqour();
            f.Show();
        }

        private void btnMeat_Click(object sender, EventArgs e)
        {
            FormButchery f = new FormButchery(fcart);
            f.Show();
        }


        private void btnCart1_Click(object sender, EventArgs e)
        {
            FormCart f = new FormCart();
            f.Show();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {


        }
        private void panelButchery_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void panelGrocery_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FoodTotal2_Click(object sender, EventArgs e)
        {

        }



        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
