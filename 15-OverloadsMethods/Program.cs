using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OverloadsMethods
{
    public class Bank
    {
        public double Withdraw(double value)
        {
            return value;
        }

        public double Withdraw(string value)
        {
            return 3.40;
        }

        public double Withdraw(double value, string cpf)
        {
            return value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank =new Bank();
            bank.Withdraw("90998375268");
            bank.Withdraw(840.0);
        }
    }
}
