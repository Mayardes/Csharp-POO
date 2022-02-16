using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Linq
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var pars = (from n in numbers
                         where (n % 2) == 0
                         select n);

            foreach(var item in pars)
                Console.WriteLine(item);
                    
        }
    }
}
