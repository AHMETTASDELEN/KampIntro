using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Addeed" + " : " + customer.FirstName + " " + customer.LastName);
        }

        public void Deleted(Customer customer)
        {
            Console.WriteLine("Customer Deleted" + " : " + customer.FirstName + " " + customer.LastName);
        }
    }
}
