using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDeligate
{
    public delegate void SampleDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SimpleMethod1);
            del2 = new SampleDelegate(SimpleMethod2);
            del3 = new SampleDelegate(SimpleMethod3);
            //del4 = new SampleDelegate(SimpleMethod4);
            del4 = del1 + del2 + del3;
            del4();
            Console.ReadLine();
        }
        public static void SimpleMethod1()
        {
            Console.WriteLine("Simple Method1 Delegate...");
        }
        public static void SimpleMethod2()
        {
            Console.WriteLine("Simple Method2 Delegate...");
        }
        public static void SimpleMethod3()
        {
            Console.WriteLine("Simple Method3 Delegate...");
        }
        public static void SimpleMethod4()
        {
            Console.WriteLine("Simple Method4 Delegate...");
        }
    }
}
