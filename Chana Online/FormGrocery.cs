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

        //create form fields so this form can open the shop and cart
        FormCart fcart;
        Form1 fshop;
        public FormGrocery(FormCart fc, Form1 fs)
        {
            InitializeComponent();
            this.fcart = fc;
            this.fshop = fs;
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

        private void groceryNum1_ValueChanged(object sender, EventArgs e)
        {
            //calculate the total cost and assign it to a variable
            double totalCost = Math.Round(grocery1.Cost * Convert.ToDouble(groceryNum1.Value) * (1 + grocery1.VAT), 2);

            //display the total cost and assign it to the TotalCost property of the object
            foodTotal1.Text = Convert.ToString(totalCost);
            grocery1.TotalCost = totalCost;

            //change the quantity property of ythe object
            grocery1.Quantity = $"{Convert.ToString(groceryNum1.Value)}";
        }
        private void groceryNum2_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(grocery2.Cost * Convert.ToDouble(groceryNum2.Value) * (1 + grocery2.VAT), 2);

            foodTotal2.Text = Convert.ToString(totalCost);

            grocery2.TotalCost = totalCost;
            grocery2.Quantity = $"{Convert.ToString(groceryNum2.Value)}";
        }

        private void groceryNum3_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(grocery3.Cost * Convert.ToDouble(groceryNum3.Value) * (1 + grocery3.VAT), 2);

            foodTotal3.Text = Convert.ToString(totalCost);

            grocery3.TotalCost = totalCost;
            grocery3.Quantity = $"{Convert.ToString(groceryNum3.Value)}";
        }


        private void addToCart_Click(object sender, EventArgs e)
        {
            //get the button's name and depending on what button is clicked, add the button's corresponding item to the cart
            var button = sender as Button;
            System.Diagnostics.Debug.WriteLine(button.Name);
            switch (button.Name)
            {
                case "addFood1":
                    addGroceryToCart(grocery1);
                    break;
                case "addFood2":
                    addGroceryToCart(grocery2);
                    break;
                case "addFood3":
                    addGroceryToCart(grocery3);
                    break;
                default:
                    Console.WriteLine("do nothing");
                    break;
            }
        }

        private void addGroceryToCart(Grocery grocery)
        {
            if(grocery.Quantity != "0")
            {
                fcart.GridViewGrocery.Rows.Add(grocery.Name, grocery.Quantity, grocery.VAT, grocery.TotalCost);
                string message = $"Your item {grocery.Name} with quantity {grocery.Quantity} has been added to the cart";
                string title = "Added to cart";
                ShowMessage(message, title);
            }
            else
            {
                string message = "Please enter a valid number before addding to cart";
                string title = "Invalid Quantity";
                ShowMessage(message, title);
            }
        }

        //this function is for showing a message box to the user
        private void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }


        //this function will put the cart into focus
        private void showCart(object sender, EventArgs e)
        {
            fcart.Focus();
        }


        //this function will put the home pagfe in focus
        private void showForm(object sender, EventArgs e)
        {
            fshop.Focus();
        }
    }
}
