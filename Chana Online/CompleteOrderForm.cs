using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chana_Online
{
    public partial class CompleteOrderForm : Form
    {
        //create a total private member
        private double _total;
        //receive the total argument from the cart form
        public CompleteOrderForm(double total)
        {
           
            InitializeComponent();
            //assign the total argument from the cart from to the private member _total and display it on the label on the checkout.
            this._total = total;
            labelTotal.Text = Convert.ToString(Math.Round(_total,2));
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            //if a textbox or numericUpAndDown is empty, prompt the user to enter the missing details in order to complete their order
            if(ccNumberBox.Value == 0)
            {
                ShowMessage("Please enter a valid Credit card number", "Invalid CC Number");
            }else if (phoneNumberBox.Value == 0)
            {
                ShowMessage("Please enter a valid Credit phone number", "Invalid phone Number");
            }else if (addressBox.Text == "")
            {
                ShowMessage("Please enter a valid Address", "Invalid addresss");
            }
            else
            {
                ShowMessage("Your order is on the way, have a nice day!", "Successfully");
            }
        }

        private void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }
    }
}
