using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Delegates
{
    public class BankSlip
    {
        public void ToPay(double value)
        {
            Console.WriteLine("Ticket payment in value of " + value);
        }

    }
    public class Order
    {
        private BankSlip _bankSlip;

        public Order()
        {
            this._bankSlip = new BankSlip();
        }
        public void Close(double value)
        {
            //using delegates
            this._bankSlip.ToPay(value);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            BankSlip bankSlip = new BankSlip();
            bankSlip.ToPay(120);

            Order order = new Order();
            order.Close(150);
        }
    }
}
