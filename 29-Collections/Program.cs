using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var team = new ArrayList();
            team.Add("Oliveira");
            team.Add("Souza");
            team.Add(10);
            team.Add(true);
            team.Add(new StringBuilder());

            foreach(object item in team)
                Console.WriteLine(item);

            Console.WriteLine(team.Capacity);
            Console.WriteLine(team.Count);
            var texto = (team[4] as StringBuilder).Append("teste");
            Console.WriteLine(team[4]);
            Console.ReadLine();
        }
    }
}
