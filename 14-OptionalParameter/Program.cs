using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OptionalParameter
{
    public class Student
    {
        public void ToStudy(string subject, string nameStudent ="")
        {
            Console.WriteLine(subject + nameStudent);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();

            student.ToStudy("CSharp");
            student.ToStudy("JavaScript","Mayardes");
        }
    }
}
