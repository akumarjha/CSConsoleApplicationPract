using System;
using System.IO;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CustomExceptionDemo("This is custome exception...");
            }
            catch (CustomExceptionDemo ce)
            {
                Console.WriteLine(ce.Message);
            }
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"C:\New folder\log.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
                Console.WriteLine("Finally block.....");
            }
            Console.ReadLine();
        }
    }
}
