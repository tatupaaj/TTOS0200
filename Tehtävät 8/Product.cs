using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Product
    {
        public string Nimi { get; set; }
        public string Hinta { get; set; }

        public override string ToString()
        {
            return "-Product: " + Nimi + " " + Hinta;
        }
    }

    class Products
    {
        private List<Product> products;
        public List<Product> ProductList { get { return products; } }

        public Products()
        {
            products = new List<Product>();
        }

        public void NewProduct(Product tuote)
        {
            products.Add(tuote);
        }
    }
}
