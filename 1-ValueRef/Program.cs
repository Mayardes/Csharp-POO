using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ValueRef
{
    public class Custumer : Object
    {
        public int Code;
        public string Name;
        public string Telephone;

        public override string ToString()
        {
            return "Code: " + Code + " Name: " + Name + "Telephone: " + Telephone;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //using value types
            int x = 10;
            string s = "Mayardes";
            bool b = false;
            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(b);

            //using reference types
            Custumer custumer1 = new Custumer();
            custumer1.Code = 123;
            custumer1.Name = "Mathew";
            custumer1.Telephone = "28 44452122";

            Custumer custumer2 = new Custumer();
            custumer2.Code = 123;
            custumer2.Name = "Mathew";
            custumer2.Telephone = "28 44452122";

            if(custumer1.Equals(custumer2))
                Console.WriteLine("custumer1 and custumer2 are equals");
            else
                Console.WriteLine("custumer1 and custumer2 are differents");

            Console.WriteLine(custumer1);
            Console.WriteLine(custumer2);

        }
    }
}
