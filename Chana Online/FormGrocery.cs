using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chana_Online
{
    public partial class FormGrocery : Form
    {
        Grocery grocery1 = new Grocery("Top Score 1kg", "https://i.ibb.co/hdKxxKQ/Top-score-1kg.jpg", 14.99, 0.10);
        Grocery grocery2 = new Grocery("Tastic Rice 1kg", "https://i.ibb.co/HGjQgHX/Tastic-1kg.jpg", 17.99, 0.10);
        Grocery grocery3 = new Grocery("Shells Polana Pasta 1kg", "https://i.ibb.co/hVwQ2Yv/shells-polana-pasta-1kg.jpg", 29.99, 0.10);

        FormCart fcart;
        public FormGrocery(FormCart fc)
        {
            InitializeComponent();
            this.fcart = fc;
        }

        private void FormGrocery_Load(object sender, EventArgs e)
        {
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

        private void addToCart_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            System.Diagnostics.Debug.WriteLine(button.Name);
            switch (button.Name)
            {
                case "Meat1":
                    //cart.Add(meat1);
                    break;
                case "Meat2":
                    // cart.Add(meat2);
                    break;
                case "Meat3":
                    // cart.Add(meat2);
                    break;
                default:
                    Console.WriteLine("do nothing");
                    break;
            }
        }


        private void groceryNum1_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(grocery1.Cost * Convert.ToDouble(groceryNum1.Value) * (1 + grocery1.VAT),2);

            foodTotal1.Text = Convert.ToString(totalCost);

            grocery1.TotalCost = totalCost;
        }
        private void groceryNum2_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(grocery2.Cost * Convert.ToDouble(groceryNum2.Value) * (1 + grocery2.VAT), 2);

            foodTotal2.Text = Convert.ToString(totalCost);

            grocery2.TotalCost = totalCost;

        }

        private void groceryNum3_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(grocery3.Cost * Convert.ToDouble(groceryNum3.Value) * (1 + grocery3.VAT), 2);

            foodTotal3.Text = Convert.ToString(totalCost);

            grocery3.TotalCost = totalCost;

        }

        private void showCart(object sender, EventArgs e)
        {
            FormCart f = new FormCart();
            f.Show();
        }

        private void showForm(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
