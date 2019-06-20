using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ExceptionHandlingAbuse
    {
        public void Abuse()
        {
            int numerator, denomurator, result;
            try
            {
                Console.WriteLine("Enter Numerator:");
                numerator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Denomurator:");
                denomurator = Convert.ToInt32(Console.ReadLine());
                result = numerator / denomurator;
            }
            catch (FormatException fm)
            {
                Console.WriteLine("Only Numbers are allowed..");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Only Numbers are in range {0} to {1}",int.MinValue,int.MaxValue);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Denom should not be 0");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some other exception occurs");
            }           
        }
    }
}
