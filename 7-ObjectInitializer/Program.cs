using System;
using System.Collections.Generic;
using System.Text;

namespace _7_ObjectInitializer
{
    public class Activities
    {
        public string Name { get; set; }
        public int Time { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Activities> ListActivities { get; set; }

        public Person()
        {

        }
        public Person(int id)
        {
            this.Id = id;
        }
        public Person(int id, string name) : this(id)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id: " + Id);
            sb.AppendLine("Name: " + Name);

            foreach (Activities activies in ListActivities)
            {
                sb.AppendLine("Activites: " + activies.Name + " Time: " + activies.Time);
            }

            return sb.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //using object initializer 
            Person person = new Person()
            {
                Id = 1,
                Name = "Mayardes",
                ListActivities = new List<Activities>()
                {
                    new Activities()
                    {
                        Name = "To develop",
                        Time = 4
                    },
                    new Activities()
                    {
                        Name = "To Work",
                        Time = 8
                    }
                }


            };

            Console.WriteLine(person);

        }
    }
}
