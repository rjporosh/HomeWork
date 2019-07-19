using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopAppPractice3
{
    public class Shop
    {
        public Shop()
        {
            product = new Product();
            listProduct = new List<Product>();
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public Product product { get; set; }
        public List<Product> listProduct { get; set; }

        private bool Duplicate(string id)
        {
            foreach (Product aProduct in listProduct)
            {
                if (aProduct.Id == id)
                {
                    return true;
                }
            }


            return false;

        }
        public void Update(Product anProduct)
        {
            foreach (Product aProduct in listProduct)
            {
                if (aProduct.Id == anProduct.Id)
                {
                    aProduct.Quantity += anProduct.Quantity;
                }
            }
        }
        public bool addItem(Product pr)
        {
            if(Duplicate(pr.Id))
            {
                Update(pr);
                return false;
            }
            else
            {
                listProduct.Add(pr);
                return true;
            }
        }
        public string showList()
        {
           
            string header = "Id. \t\t Quantity";
            string rows = "";
            if (listProduct.Count > 0)
            {

                foreach (Product item in listProduct)
                {
                    rows += item.Id + " \t\t " + item.Quantity+ Environment.NewLine;
                }
            }

            string message =  header + Environment.NewLine + rows;
            return message;
        }
    }
}
