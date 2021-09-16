using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chana_Online
{
    public partial class FormCart : Form
    {
        public double Total { get; set; }

        public FormCart()
        {
            InitializeComponent();
            Total = 0;
        }

        private void FormCart_Load(object sender, EventArgs e)
        {

        }


        //this function is responsible for adding the items to the cart
        //the function will accept the item details as arguments and add them to the cart
        public void AddItemsToCart(string Name, string Quantity, double VAT, double TotalCost)
        {
            GridViewButchery.Rows.Add(Name, Quantity, VAT, TotalCost);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemsToCart("ijioi", "frrever", 23, 323);
        }



        private void showShop(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }


        public void CalculateTotal()
        {
            labelTotal.Text = "0";
            //get the total by looping through all the rows in each gridview
            double total = double.Parse(labelTotal.Text);
            for (int i = 0; i < GridViewGrocery.Rows.Count; i++)
            {
                total += double.Parse(GridViewGrocery.Rows[i].Cells[3].Value.ToString());
            }

            for (int i = 0; i < GridViewButchery.Rows.Count; i++)
            {
                total += double.Parse(GridViewButchery.Rows[i].Cells[3].Value.ToString());
            }

            for (int i = 0; i < GridViewLiqour.Rows.Count; i++)
            {
                total += double.Parse(labelTotal.Text) + double.Parse(GridViewLiqour.Rows[i].Cells[3].Value.ToString());
            }

            ///display the total
            labelTotal.Text = Convert.ToString(Math.Round(total, 2));

            //assing the total to the public member so that it can be used by another form;
            Total = total;
        }

        private void getTotal_Click(object sender, EventArgs e)
        {
            
        }

        //this function will display the checkout form so the user can complete their order
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CompleteOrderForm checkout = new CompleteOrderForm(Total);
     
            checkout.Show();
        }
    }
}
