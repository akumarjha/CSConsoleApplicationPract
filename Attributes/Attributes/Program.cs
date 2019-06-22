using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of two int ={0}",Calculator.Add(10, 20)); //This is Obsolete Method for error we can pass true in 2nd parameter
            Console.WriteLine("Addition of List of int ={0}",Calculator.Add(new List<int>(){10,20,30,40}));
            Console.ReadLine();
        }
    }
    public class Calculator
    {
        [Obsolete(" Use List<int> numbers method")]
        public static int Add(int Fn, int Sn)
        {
            return Fn + Sn;
        }
        public static int Add(List<int> numbers)
        {
            int Sum = 0;
            foreach (int number in numbers)
            {
                Sum += number;
            }
            return Sum;
        }
    }
}
