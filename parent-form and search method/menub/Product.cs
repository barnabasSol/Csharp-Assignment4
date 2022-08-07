using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menub
{
    class Product
    {

        private static List<Product> products = new List<Product>();
        public string name { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public string type { get; set; }

        private static List<Product> search_result = new List<Product>();

        public static List<Product> get_products()
        {
            return products;
        }

        public static List<Product> get_srch_rslt()
        {
            return search_result;
        }

        public void addproduct(Product newp)
        {
            products.Add(newp);
        }

        public static Product find_one(string name)
        {
            return products.Find(p => p.name == name);
        }

        public static void add_search_result(Product p)
        {
            search_result.Add(p);
        }


    }
}
