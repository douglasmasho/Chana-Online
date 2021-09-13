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

        public void AddItemsToCart(string Name, string Quantity, double VAT, double TotalCost)
        {
            System.Diagnostics.Debug.WriteLine("2444444");
            GridViewButchery.Rows.Add(Name, Quantity, VAT, TotalCost);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemsToCart("ijioi", "frrever", 23, 323);
        }
    }
}
