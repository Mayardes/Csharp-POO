using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Delegates
{
    public delegate void DelegateFunction(double balance);

    public class ToPay
    {
        public event DelegateFunction EventFunction;

        public void Init(DelegateFunction delegates)
        {
            delegates(25);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ToPay topay = new ToPay();

            topay.Init(valor => Console.WriteLine("thicket payment in value of "+ valor));
        }

        private static void Topay_EventFunction(double balance)
        {
            Console.WriteLine("Ticket payment value is " + balance);
        }
    }
}
