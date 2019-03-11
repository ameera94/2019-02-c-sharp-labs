using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace lab_10_entity
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
           
            //CRUD C:create, R:read, U:update, D:delete

            // select one customer
            using (var db = new NorthwindEntities())
            {
                // LINQ query  :  Microsoft  :  Language Independent Query
                //var customertoUpdate =
                //    //select all customers in NW
                //    (from customer in db.Customers
                //    //choose one where ID matches
                //    where customer.CustomerID == "ALFKI"
                //    //output this one selected (doesn't inherently know so use first or default to choose just one otherwise array)
                //    select customer).FirstOrDefault();
                //Console.WriteLine("\n\nFinding one customer\n");
                //Console.WriteLine($"{customertoUpdate.ContactName} lives in {customertoUpdate.City}");

                //OR use 
                var customertoUpdate =
                   db.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault();
                Console.WriteLine("\n\nFinding one customer\n");
                Console.WriteLine($"{customertoUpdate.ContactName} lives in {customertoUpdate.City}");

                //UPDATE
                customertoUpdate.ContactName = "Fred Flinstone";
                //Update DB permanently
                db.SaveChanges();
            }

            
            using (var db = new NorthwindEntities())
            {
                //INSERT new customer
                //Customer customerToCreate = new Customer
                //{
                //    CustomerID = "AMI94",
                //    ContactName = "Amira",
                //    City = "London",
                //    CompanyName = "Sparta"
    
                //};

                ////now add new customer to local database
                //db.Customers.Add(customerToCreate);
                ////write changes permanently to real database. 
                //db.SaveChanges();

            }

            //have a look at customers after INSERT and UPDATE
            Console.WriteLine("\n\nView customers after INSERT and UPDATE\n\n");
            DisplayAll();



            //TO DELETE
            using (var db = new NorthwindEntities())
            {
                Customer customerToDelete = db.Customers.Where(c => c.CustomerID == "AMI94").FirstOrDefault();
                {
                    db.Customers.Where(c => c.CustomerID == "AMI94").FirstOrDefault();
                    db.Customers.Remove(customerToDelete);
                    db.SaveChanges();
                };
                
            }
            //have a look at customers after DELETE
            Console.WriteLine("\n\nView customers after Delete\n\n");
            DisplayAll();

        }



        static void DisplayAll()
        {
            using (var db = new NorthwindEntities())
            {
                //customers list = (read from northwind )
                //                  (pull out all customers)
                //                  send to list of customers)
               var customers = db.Customers.ToList<Customer>();
            }

            //use list!!!
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.ContactName} has ID {customer.CustomerID} from {customer.City}");
            }
        }
    }
}
