using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Encapsulation
{
    public class Account
    {
        private string _custumer;
        private double _balance;

        public Account(string custumer, double balance)
        {
            this._custumer = custumer;
            this._balance = balance;
        }
        public void WithDraw(double value)
        {
            this._balance -= value;
        }

        public void Deposit(double value)
        {
            this._balance += value;
        }

        public string GetCustumer()
        {
            return this._custumer;
        }
        public void SetCustumer(string custumer)
        {
            this._custumer = custumer;
        }
        public void SetBalance(double balance)
        {
            this._balance = balance;
        }



        public double GetBalance()
        {
            return this._balance;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Mayardes", 10000);
            account.SetCustumer("Oliveira");
            account.WithDraw(500);

            Console.WriteLine($"{account.GetCustumer()}, your account balance is: ${account.GetBalance()}");
        }
    }
}
