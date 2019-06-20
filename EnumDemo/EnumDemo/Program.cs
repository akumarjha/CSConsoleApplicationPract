using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer()
            {
                Name="Ashutosh",
                Gender=1
            };
            customers[1] = new Customer()
            {
                Name = "Alok",
                Gender = 1
            };
            customers[2] = new Customer()
            {
                Name = "Marry",
                Gender = 2
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer Name ={0} and Gender ={1}", customer.Name, GetGender(customer.Gender));
            }
            Console.ReadLine();
        }
        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0 :
                    return "Unknown";
                case 1 :
                    return "Male";
                case 2 :
                    return "Female";
                default :
                    return "Incalid Input";
            }
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
