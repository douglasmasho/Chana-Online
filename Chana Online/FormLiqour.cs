using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chana_Online
{
    public partial class FormLiqour : Form
    {
        Liqour liqour1 = new Liqour("Hennessy", "https://i.ibb.co/sRwLRgF/hennessy-X-O.jpg", 60);
        Liqour liqour2 = new Liqour("Jameson", "https://i.ibb.co/NNtRsrf/liquor-store-jameson-select-reserve.jpg", 85);
        Liqour liqour3 = new Liqour("Amarula", "https://i.ibb.co/LSw8XK5/liquor-store.jpg", 110.5);

        //create a form cart member
        FormCart fcart;
        Form1 fshop;
        public FormLiqour(FormCart fc, Form1 fs)
        {
            InitializeComponent();
            this.fcart = fc;
            this.fshop = fs;
        }

        private void showCart(object sender, EventArgs e)
        { 
            fcart.Focus();
        }

        private void showShop(object sender, EventArgs e)
        {
            fshop.Focus();
        }

        private void FormLiqour_Load(object sender, EventArgs e)
        {

            liqourPic3.LoadAsync(liqour3.ImageURL);
            liqourLabel3.Text = liqour3.Name;
            liqourCost3.Text = Convert.ToString(liqour3.Cost);
            liqourvat3.Text = Convert.ToString(liqour3.VAT);

            liqourPic1.LoadAsync(liqour1.ImageURL);
            liqourLabel1.Text = liqour1.Name;
            liqourCost1.Text = Convert.ToString(liqour1.Cost);
            liqourvat1.Text = Convert.ToString(liqour1.VAT);

            liqourPic2.LoadAsync(liqour2.ImageURL);
            liqourLabel2.Text = liqour2.Name;
            liqourCost2.Text = Convert.ToString(liqour2.Cost);
            liqourvat2.Text = Convert.ToString(liqour2.VAT);
        }



        private void liqourL1_ValueChanged(object sender, EventArgs e)
        {
            //calculate the total cost
            //save it in a variable
            double totalCost = Math.Round(liqour1.Cost * Convert.ToDouble(liqourL1.Value) * (1 + liqour1.VAT), 2);

            //assign it to the the TotalCost property in the object and display it
            totalL1.Text = Convert.ToString(totalCost);
            liqour1.TotalCost = totalCost;
            //assign the quantity to the Quantity property of the object
            liqour1.Quantity = $"{Convert.ToString(liqourL1.Value)} Litres";
        }

        private void liqourL2_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(liqour2.Cost * Convert.ToDouble(liqourL2.Value) * (1 + liqour2.VAT), 2);

            totalL2.Text = Convert.ToString(totalCost);

            liqour2.TotalCost = totalCost;
            liqour2.Quantity = $"{Convert.ToString(liqourL2.Value)} Litres";
        }

        private void liqourL3_ValueChanged(object sender, EventArgs e)
        {
            double totalCost = Math.Round(liqour3.Cost * Convert.ToDouble(liqourL3.Value) * (1 + liqour3.VAT), 2);

            totalL3.Text = Convert.ToString(totalCost);

            liqour3.TotalCost = totalCost;
            liqour3.Quantity = $"{Convert.ToString(liqourL3.Value)} Litres";
        }

        private void addliqourToCart_Click(object sender, EventArgs e)
        {
            //get the button's name and depending on what button is clicked, add the button's corresponding item to the cart
            var button = sender as Button;
            System.Diagnostics.Debug.WriteLine(button.Name);
            switch (button.Name)
            {
                case "addliqour3":
                    addliqourToCart(liqour3);
                    System.Diagnostics.Debug.WriteLine("did the thing");
                    break;
                case "addliqour1":
                    addliqourToCart(liqour1);
                    break;
                case "addliqour2":
                    addliqourToCart(liqour2);
                    break;
                default:
                    Console.WriteLine("do nothing");
                    break;
            }
        }

        private void addliqourToCart(Liqour liqour)
        {
            if(liqour.Quantity != "0")
            {
                fcart.GridViewLiqour.Rows.Add(liqour.Name, liqour.Quantity, liqour.VAT, liqour.TotalCost);
                string message = $"Your item {liqour.Name} with quantity {liqour.Quantity} has been added to the cart";
                string title = "Added to cart";
                ShowMessage(message, title);
            }
            else
            {
                string message = "Please enter a valid number before addding to cart";
                string title = "Invalid Qunatity";
                ShowMessage(message, title);
            }
        }

        //this function is for showing a message box to the user
        private void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }



        private void showForm(object sender, EventArgs e)
        {
            fshop.Focus();
        }
    }
}
