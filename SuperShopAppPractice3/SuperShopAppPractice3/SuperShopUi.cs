using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopAppPractice3
{
    public partial class SuperShopUi : Form
    {
        Shop s;
        Product p;
        public SuperShopUi()
        {
            InitializeComponent();
            s = new Shop();
            p = new Product();
            Debug.WriteLine("constructor fired");
        }

        private void ShopSaveButton_Click(object sender, EventArgs e)
        {
            s.Name = nameTextBox.Text;
            s.Address = addressTextBox.Text;
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            MessageBox.Show("Shop Saved");
        }

        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            Product productObj = new Product(itemTextBox.Text, Convert.ToDouble(quantityTextBox.Text));

            bool isAdded = s.addItem(productObj);

            if (isAdded)
            {
                itemTextBox.Text = "";
                quantityTextBox.Text = "";
                MessageBox.Show("Product Added.");
            }
            else
            {
                itemTextBox.Text = "";
                quantityTextBox.Text = "";
                MessageBox.Show("Product is Updated.");
            }
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.showList());
        }
    }
}
