using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;

namespace _31_Dictonary
{
    public class Student
    {
        public int Registration { get; set; }
        public string Name { get; set;}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Registration: " + Registration);
            sb.AppendLine("Name: " + Name);

            return sb.ToString();
        }
    }
    public class ListElements<T>
    {
        private Dictionary<int,T> _products;
        public ListElements()
        {
            this._products = new Dictionary<int, T>();
        }

        public Dictionary<int,T> GetList()
        {
            return this._products;
        }

        public void Add(int key, T element)
        {
            this._products.Add(key, element);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            var list = new ListElements<Student>();
            list.Add(1, new Student() { Name = "Mayardes", Registration = 1});
            list.Add(2, new Student() { Name = "Maria", Registration = 2});
            list.Add(3, new Student() { Name = "Lourdes", Registration = 3});
            list.Add(4, new Student() { Name = "Helena", Registration = 4 });

            foreach(var item in list.GetList().Values)
                Console.WriteLine(item);

            foreach(KeyValuePair<int, Student> kvp in list.GetList())
                Console.WriteLine(kvp.Key);

        }
    }
}
