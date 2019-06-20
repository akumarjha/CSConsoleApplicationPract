using System;
using System.IO;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\New folder\log.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            Console.ReadLine();
        }
    }
}
