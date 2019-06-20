using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    public class EnumsSolved
    {
        static void Main(string[] args)
        {
            Customer1[] customers = new Customer1[3];
            customers[0] = new Customer1()
            {
                Name="Ashutosh",
                Gender=Gender.Male
            };
            customers[1] = new Customer1()
            {
                Name = "Alok",
                Gender = Gender.Male
            };
            customers[2] = new Customer1()
            {
                Name = "Marry",
                Gender = Gender.Female
            };
            foreach (Customer1 customer in customers)
            {
                Console.WriteLine("Customer Name ={0} and Gender ={1}", customer.Name, GetGender(customer.Gender));
            }
            Console.ReadLine();
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown :
                    return "Unknown";
                case Gender.Male :
                    return "Male";
                case Gender.Female :
                    return "Female";
                default :
                    return "Incalid Input";
            }
        }
    }
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    public class Customer1
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
