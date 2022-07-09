using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applyCustomer
{
    class Customer
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string nationality { get; set; }
        public string birth_date { get; set; }
        public string address { get; set; }

       public  Customer()
        {

        }
        public Customer(string fname, string lname, string natn, string bdate, string ads)
        {
            first_name = fname;
            last_name = lname;
            nationality = natn;
            birth_date = bdate;
            address = ads;
        }
        public void addCustomer()
        {
            Console.WriteLine("customer added");
        }
       
    }
}
