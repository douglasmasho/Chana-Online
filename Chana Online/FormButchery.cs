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
        //create meat objects that will be displayed on the page
        Meat meat1 = new Meat("Chicken", "https://i.ibb.co/BVG7yGY/breasts.jpg", 60, 0.15);
        Meat meat2 = new Meat("Lamb Sausage", "https://i.ibb.co/rZQzVgY/pork-sausage.jpg", 85, 0.15);
        Meat meat3 = new Meat("Steak", "https://i.ibb.co/NWGMQTt/farhad-ibrahimzade-Hhbc-Ihf9vho-unsplash.jpg", 110.5, 0.15);

        //create a cart form member
        FormCart fcart;
        //create a main page form member
        Form1 fshop;

        public FormButchery(FormCart fc, Form1 fs)
        {
            InitializeComponent();
            //set it in the consturctor
            this.fcart = fc;
            this.fshop = fs;

        }

        private void FormButchery_Load(object sender, EventArgs e)
        {
            //display the meat object details on their corresponding labels and picture boxes
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


        private void meatkgs1_ValueChanged(object sender, EventArgs e)
        {
            //calculate the total cost
            //save it in a variable
            double totalCost = Math.Round(meat1.CostperKG * Convert.ToDouble(meatkgs1.Value) * (1 + meat1.VAT), 2);

            //assign it to the the TotalCost property in the object and display it
            meatTotal1.Text = Convert.ToString(totalCost);
            meat1.TotalCost = totalCost;

            //assign the quantity to the Quantity property of the object
            meat1.Quantity = $"{Convert.ToString(meatkgs1.Value)} kg";
        }

        private void meatkgs2_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(meat2.CostperKG * Convert.ToDouble(meatkgs2.Value) * (1 + meat2.VAT), 2);

            meatTotal2.Text = Convert.ToString(totalCost);

            meat2.TotalCost = totalCost;
            meat2.Quantity = $"{Convert.ToString(meatkgs2.Value)} kg";
        }

        private void meatkgs3_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(meat3.CostperKG * Convert.ToDouble(meatkgs3.Value) * (1 + meat3.VAT), 2);

            meatTotal3.Text = Convert.ToString(totalCost);

            meat3.TotalCost = totalCost;
            meat3.Quantity = $"{Convert.ToString(meatkgs3.Value)} kg";


        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //get the button's name and depending on what button is clicked, add the button's corresponding item to the cart
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
            if(meat.Quantity != "0")
            {
                fcart.GridViewButchery.Rows.Add(meat.Name, meat.Quantity, meat.VAT, meat.TotalCost);
                //calculate the total after adding the item to the cart
                fcart.CalculateTotal();
                string message = $"Your item {meat.Name} with quantity {meat.Quantity} has been added to the cart";
                string title = "Added to cart";
                ShowMessage(message, title);
            }
            else
            {
                string message = "Please enter a valid number before addding to cart";
                string title = "Invalid Kilograms";
                ShowMessage(message, title);
            }
        }

        //this function is for showing a message box to the user
        private void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        private void showCart(object sender, EventArgs e)
        {
            fcart.Focus();
        }

        private void showForm(object sender, EventArgs e)
        {
            fshop.Focus();
        }
    }
}
