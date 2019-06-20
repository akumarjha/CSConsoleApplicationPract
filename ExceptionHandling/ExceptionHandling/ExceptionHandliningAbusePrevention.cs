using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ExceptionHandliningAbusePrevention
    {
        public void AbusePrevention()
        {
            int numerator, denomurator, result;
            bool IsNumeratorConvertable;
            bool IsDenomratorConvertable ;
            try
            {
                Console.WriteLine("Enter Numerator:");
                IsNumeratorConvertable = int.TryParse(Console.ReadLine(), out numerator);
                if (IsNumeratorConvertable)
                {
                    Console.WriteLine("Enter Denomurator:");
                    IsDenomratorConvertable = int.TryParse(Console.ReadLine(), out denomurator);
                    if (IsDenomratorConvertable && denomurator != 0)
                    {
                        result = numerator / denomurator;
                        Console.WriteLine("result ={0}", result);
                    }
                    else
                    {
                        if (denomurator == 0)
                        {
                            Console.WriteLine("Denomerator should not be 0");
                        }
                        else
                        {
                            Console.WriteLine("Denomerator should be between {0} and {1}",int.MinValue,int.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Numerator should be between {0} and {1}", int.MinValue, int.MaxValue);
                    //Console.WriteLine("Only Numbers are allowed..");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some other exception occurs {0}",ex);
            }
        }
    }
}
