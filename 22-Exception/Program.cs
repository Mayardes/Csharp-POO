using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Exception
{
    public class LogErroException : Exception
    {
        public LogErroException(string message):base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = Convert.ToInt32(4);
                int r = x/0;

            }catch(LogErroException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static int ToCalculate(int x)
        {
            return x/0;
        }
    }
}
