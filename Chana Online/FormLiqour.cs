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
        public FormLiqour()
        {
            InitializeComponent();
        }

        private void showCart(object sender, EventArgs e)
        {
            FormCart f = new FormCart();
            f.Show();
        }

        private void showShop(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
