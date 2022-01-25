using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Properties
{
    public class MonthlyPaymentNegativeException : Exception
    {
        public MonthlyPaymentNegativeException(string message) : base(message)
        {

        }
    }
    public enum TypeStudent
    {
        Regular,
        Especial
    }
    public class Student
    {
        private int _registration;
        private string _name;
        private double _monthlyPayment;
        private TypeStudent _typeStudent;
        public int Registration
        {
            get { return this._registration; }
            set { this._registration = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public double MonthlyPayment
        {
            get { return this._monthlyPayment; }
            set
            {
                if (value > 0)
                    this._monthlyPayment = value;
                else
                    throw new MonthlyPaymentNegativeException("Account error: Invalid value");
            }
        }

        public TypeStudent TypeStudent
        {
            get { return this._typeStudent; }
            set { this._typeStudent = value; }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student();
                student.Registration = 123;
                student.MonthlyPayment = -123;
                student.Name = "Richard";
                student.TypeStudent = TypeStudent.Regular;
            }
            catch (MonthlyPaymentNegativeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
