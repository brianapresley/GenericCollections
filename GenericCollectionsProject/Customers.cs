using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsProject {

    public class Customers {

        List<Customer> customerList = new List<Customer>();

        public void LoadCustomers() {
            var cust1 = new Customer { Name = "P&G", State = "OH" };
            var cust2 = new Customer { Name = "Microsoft", State = "WA" };
            var cust3 = new Customer { Name = "Target", State = "MN" };

            customerList.Add(cust1);
            customerList.Add(cust2);
            customerList.Add(cust3);

        }

        public void PrintCustomers() { //Get each name in customer list and display
            foreach (var cust in customerList) {
                Console.WriteLine($"The customer name is {cust.Name} and they are located in {cust.State}");
            }
        }

        public class Customer {
            public string Name { get; set; }
            public string State { get; set; }
        }
    }
}
