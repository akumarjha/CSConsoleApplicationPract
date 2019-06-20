using System;
using System.IO;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
