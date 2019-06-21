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
            string[] names = Enum.GetNames(typeof(Gender2));
            foreach (string name in names)
            {
                Console.WriteLine("Name is : {0}", name);
            }
            Gender2[] values = (Gender2[])Enum.GetValues(typeof(Gender2));
            foreach (int value in values)
            {
                Console.WriteLine("Value is : {0}", value);
            }

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
    public enum Gender1 :short // by default Type of enum is Int but we can change it 
    {
        Unknown =1, // by default value starts from 0 but but we can start from anywhere within the range of Short
        Male, //2
        Female //3
    }
    public enum Gender2 : short // by default Type of enum is Int but we can change it 
    {
        Unknown = 1, // by default value starts from 0 but but we can start from anywhere within the range of Short
        Male =10, //2
        Female =50 //3
    }
    public class Customer1
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
