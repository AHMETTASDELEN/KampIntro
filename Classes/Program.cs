using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.City = "Ankara";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Ahmet";
            customer2.LastName = "Taşdelen";
            customer2.City = "Sakarya";


            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Deleted();

            ProductManager productManager = new ProductManager();
            //productManager.Add();
            //productManager.Deleted();


            

        }
    }
}
