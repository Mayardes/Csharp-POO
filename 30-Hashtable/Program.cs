using System.Collections;
using System;

namespace _30_Hashtable
{
    public class Student
    {
        public int Registration { get; set;}
        public string Name { get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Name = "Mayardes",
                Registration = 1
            };
             Student student2 = new Student()
            {
                Name = "Jhonatan",
                Registration = 2
            };
             Student student3 = new Student()
            {
                Name = "Scarlet",
                Registration = 3
            };

            var list = new Hashtable();
            list.Add(1, student1);
            list.Add(2, student2);
            list.Add(3, student3);

            Console.WriteLine((list[3] as Student).Name);
        }

        private static void NewMethod()
        {
            var list = new Hashtable();
            list.Add(1, "one");
            list.Add(2, "two");
            list.Add(true, "true");
            list.Add(new DateTime(), "DateTime");

            if (list.ContainsKey(1))
                Console.WriteLine(list[1]);

            Console.WriteLine(list[144]);
        }
    }
}
