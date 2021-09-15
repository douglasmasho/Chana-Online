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
        
        public FormCart()
        {
            InitializeComponent();
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
    }
}
