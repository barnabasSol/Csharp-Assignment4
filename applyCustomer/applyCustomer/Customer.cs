using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applyCustomer
{
    class Customer
    {
        private static List<Customer> customer_list = new List<Customer>();
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }
        public string birth_date { get; set; }
        public string address { get; set; }
        public bool male { get; set; }
        public bool female { get; set; }
        public  Customer()
        {

        }
        public Customer(string fname, string lname, int a, string natn, string bdate, string ads, bool mle, bool fem)
        {
            first_name = fname;
            last_name = lname;
            age = a;
            nationality = natn;
            birth_date = bdate;
            address = ads;
            male = mle;
            female = fem;
        }
        public void addCustomer(Customer c)
        {
            customer_list.Add(c);
        }

        public static List<Customer> get_customer_list()
        {
            return customer_list;
        }
       
    }
}
