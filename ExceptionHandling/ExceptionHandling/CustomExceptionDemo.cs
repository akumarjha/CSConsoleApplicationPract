using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class CustomExceptionDemo: Exception
    {
        public CustomExceptionDemo() : base()
        {

        }
        public CustomExceptionDemo(string message): base(message)
        {

        }
    }
}
