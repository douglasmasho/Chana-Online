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
        Meat meat2 = new Meat("Lamb Sausage", "https://i.ibb.co/rZQzVgY/pork-sausage.jpg", 85, 0.15);
        Meat meat3 = new Meat("Steak", "https://i.ibb.co/NWGMQTt/farhad-ibrahimzade-Hhbc-Ihf9vho-unsplash.jpg", 110.5, 0.15);

        Grocery grocery1 = new Grocery("Top Score 1kg", "https://i.ibb.co/hdKxxKQ/Top-score-1kg.jpg", 14.99, 0.10);
        Grocery grocery2 = new Grocery("Tastic Rice 1kg", "https://i.ibb.co/HGjQgHX/Tastic-1kg.jpg", 17.99, 0.10);
        Grocery grocery3 = new Grocery("Shells Polana Pasta 1kg", "https://i.ibb.co/hVwQ2Yv/shells-polana-pasta-1kg.jpg", 29.99, 0.10);

        List<object> cart = new List<object>();

        private void Form1_Load(object sender, EventArgs e)
        {
            panelCart.Visible = false;
            panelShop.Visible = true;
            panelButchery.Visible = false;
            panelGrocery.Visible = false;
            panelLiqour.Visible = false;

            meatPic1.LoadAsync(meat1.ImageURL);
            meatName1.Text = meat1.Name;
            meatCostpkg1.Text = Convert.ToString(meat1.CostperKG);
            butcheryVAT1.Text = Convert.ToString(meat1.VAT);

            meatPic2.LoadAsync(meat2.ImageURL);
            meatName2.Text = meat2.Name;
            meatCostpkg2.Text = Convert.ToString(meat2.CostperKG);
            butcheryVAT2.Text = Convert.ToString(meat2.VAT);

            meatPic3.LoadAsync(meat3.ImageURL);
            meatName3.Text = meat3.Name;
            meatCostpkg3.Text = Convert.ToString(meat3.CostperKG);
            butcheryVAT3.Text = Convert.ToString(meat3.VAT);

            foodPic1.LoadAsync(grocery1.ImageURL);
            foodName1.Text = grocery1.Name;
            foodCost1.Text = Convert.ToString(grocery1.Cost);
            foodVAT1.Text = Convert.ToString(grocery1.VAT);

            foodPic2.LoadAsync(grocery2.ImageURL);
            foodName2.Text = grocery2.Name;
            FoodCost2.Text = Convert.ToString(grocery2.Cost);
            foodVAT2.Text = Convert.ToString(grocery2.VAT);

            foodPic3.LoadAsync(grocery3.ImageURL);
            foodName3.Text = grocery3.Name;
            foodCost3.Text = Convert.ToString(grocery3.Cost);
            foodVAT3.Text = Convert.ToString(grocery3.VAT);
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            System.Diagnostics.Debug.WriteLine(button.Name);
            switch (button.Name)
            {
                case "Meat1":
                    cart.Add(meat1);
                    break;
                case "Meat2":
                    cart.Add(meat2);
                    break;
                case "Meat3":
                    cart.Add(meat2);
                    break;
                default: Console.WriteLine( "do nothing");
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }



        private void meatkgs1_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = meat1.CostperKG * Convert.ToDouble(meatkgs1.Value) * (1 + meat1.VAT);

            meatTotal1.Text = Convert.ToString(totalCost);

            meat1.TotalCost = totalCost;
        }

        private void meatkgs2_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = meat2.CostperKG * Convert.ToDouble(meatkgs2.Value) * (1 + meat2.VAT);

            meatTotal2.Text = Convert.ToString(totalCost);

            meat2.TotalCost = totalCost;

        }

        private void meatkgs3_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = meat3.CostperKG * Convert.ToDouble(meatkgs3.Value) * (1 + meat3.VAT);

            meatTotal3.Text = Convert.ToString(totalCost);

            meat3.TotalCost = totalCost;

        }

        private void groceryNum1_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = grocery1.Cost * Convert.ToDouble(groceryNum1.Value) * (1 + grocery1.VAT);

            foodTotal1.Text = Convert.ToString(totalCost);

            grocery1.TotalCost = totalCost;
        }
        private void groceryNum2_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = grocery2.Cost * Convert.ToDouble(groceryNum2.Value) * (1 + grocery2.VAT);

            foodTotal2.Text = Convert.ToString(totalCost);

            grocery2.TotalCost = totalCost;

        }

        private void groceryNum3_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = grocery3.Cost * Convert.ToDouble(groceryNum3.Value) * (1 + grocery3.VAT);

            foodTotal3.Text = Convert.ToString(totalCost);

            grocery3.TotalCost = totalCost;

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
