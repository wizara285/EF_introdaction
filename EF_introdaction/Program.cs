using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_introdaction
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var customer = new Customer();

                Console.WriteLine("Enter you first name: ");
                customer.First_Name = Console.ReadLine();

                Console.WriteLine("Enter you last name: ");
                customer.Last_Name = Console.ReadLine();

                Console.WriteLine("Enter you age: ");
                customer.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter you contry you live: ");
                customer.Country = Console.ReadLine();


                context.Customers.Add(customer);
                context.SaveChanges();

                Console.WriteLine($"Id: {customer.Customer_Id}, Name: {customer.First_Name}, Age: {customer.Age}");
                Console.ReadLine();

                Console.WriteLine("Hello");
            }

        }
    }
}
