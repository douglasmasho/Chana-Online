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

        Meat meat1 = new Meat("Chicken", "https://i.ibb.co/BVG7yGY/breasts.jpg", 60, 0.15);
        Meat meat2 = new Meat("Sausage", "https://i.ibb.co/rZQzVgY/pork-sausage.jpg", 60, 0.15);

        public Form1()
        {
            InitializeComponent();

        }

        private void meatkgs1_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = meat1.CostperKG * Convert.ToDouble(meatkgs1.Value) * (1 + meat1.VAT);

            meatTotal1.Text = Convert.ToString(totalCost);
        }


        private void Form1_Load(object sender, EventArgs e) { 
            panelCart.Visible = false;
            panelShop.Visible = true;
            panelButchery.Visible = false;
            panelGrocery.Visible = false;
            panelLiqour.Visible = false;

            meatPic1.LoadAsync(meat1.ImageURL);
            meatName1.Text = meat1.Name;
            meatCostpkg1.Text = Convert.ToString(meat1.CostperKG);
            butcheryVAT1.Text = Convert.ToString(meat1.VAT);

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            panelCart.Visible = false;
            panelShop.Visible = true;
            panelButchery.Visible = false;
            panelGrocery.Visible = false;
            panelLiqour.Visible = false;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            panelCart.Visible = false;
            panelShop.Visible = true;
            panelButchery.Visible = false;
            panelGrocery.Visible = true;
            panelLiqour.Visible = false;
        }

        private void btnLiqour_Click(object sender, EventArgs e)
        {
            panelCart.Visible = false;
            panelShop.Visible = true;
            panelButchery.Visible = false;
            panelGrocery.Visible = false;
            panelLiqour.Visible = true;
        }

        private void btnMeat_Click(object sender, EventArgs e)
        {
            panelShop.Visible = false;
            panelButchery.Visible = true;
        }


        private void btnCart1_Click(object sender, EventArgs e)
        {
            panelCart.Visible = true;
            panelShop.Visible = true;
            panelButchery.Visible = false;
            panelGrocery.Visible = false;
            panelLiqour.Visible = false;
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
    }
}
