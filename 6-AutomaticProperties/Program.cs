using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AutomaticProperties
{
    public class Employee
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public Employee()
        {
            this.Code = 00;
            this.Name = "unassigned";
            this.Balance = 0.0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Code: " + Code);
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Balance: " + Balance);

            return sb.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine(employee);

        }
    }
}
