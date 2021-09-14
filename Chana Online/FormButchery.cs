using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chana_Online
{
    public partial class FormButchery : Form
    {
        Meat meat1 = new Meat("Chicken", "https://i.ibb.co/BVG7yGY/breasts.jpg", 60, 0.15);
        Meat meat2 = new Meat("Lamb Sausage", "https://i.ibb.co/rZQzVgY/pork-sausage.jpg", 85, 0.15);
        Meat meat3 = new Meat("Steak", "https://i.ibb.co/NWGMQTt/farhad-ibrahimzade-Hhbc-Ihf9vho-unsplash.jpg", 110.5, 0.15);

        //create a form cart member
        FormCart fcart;
        public FormButchery(FormCart fc)
        {
            InitializeComponent();
            //set it in the consturctor
            this.fcart = fc;

        }

        private void FormButchery_Load(object sender, EventArgs e)
        {
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
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //create a cart form to get the datagridviews
            var button = sender as Button;
            System.Diagnostics.Debug.WriteLine(button.Name);
            switch (button.Name)
            {
                case "addMeat1": 
                    addMeatToCart(meat1);
                    System.Diagnostics.Debug.WriteLine("did the thing");
                    break;
                case "addMeat2":
                    addMeatToCart(meat2);
                    break;
                case "addMeat3":
                    addMeatToCart(meat3);
                    break;
                default:
                    Console.WriteLine("do nothing");
                    break;
            }
        }

        private void addMeatToCart(Meat meat)
        {
            fcart.GridViewButchery.Rows.Add(meat.Name, meat.Quantity, meat.VAT, meat.TotalCost);
        }


        private void meatkgs1_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(meat1.CostperKG * Convert.ToDouble(meatkgs1.Value) * (1 + meat1.VAT),2);

            meatTotal1.Text = Convert.ToString(totalCost);

            meat1.TotalCost = totalCost;
            meat1.Quantity = $"{Convert.ToString(meatkgs1.Value)} kg";

        }

        private void meatkgs2_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(meat2.CostperKG * Convert.ToDouble(meatkgs2.Value) * (1 + meat2.VAT),2);

            meatTotal2.Text = Convert.ToString(totalCost);

            meat2.TotalCost = totalCost;
            meat2.Quantity = $"{Convert.ToString(meatkgs2.Value)} kg";


        }

        private void meatkgs3_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(meat3.CostperKG * Convert.ToDouble(meatkgs3.Value) * (1 + meat3.VAT),2);

            meatTotal3.Text = Convert.ToString(totalCost);

            meat3.TotalCost = totalCost;
            meat3.Quantity = $"{Convert.ToString(meatkgs3.Value)} kg";


        }

        private void showCart(object sender, EventArgs e)
        {
            fcart.Show();
        }

        private void showForm(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
