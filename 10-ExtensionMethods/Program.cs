using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExtensionMethods
{
    public static class MyExtension
    {
        public static int WordCount(this string str)
        {
            return str.Count();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "mayardes";
            Console.WriteLine(name.Count());
        }
    }
}
