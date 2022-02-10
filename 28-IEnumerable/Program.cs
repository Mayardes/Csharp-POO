using System.Collections;
using System.Collections.Generic;

namespace _28_IEnumerable
{
    public class ListCustumers : IEnumerable
    {
        private List<string> _custumers;
        private int _index;
        public ListCustumers()
        {
            this._custumers = new List<string>();
            this._index = 0;
        }

        public ICollection<string> getCliente()
        {
            return this._custumers;
        }

        public string this [int index]
        {
            get { return this._custumers[index].ToString(); }
        }

        public int SizeList()
        {
            return this._custumers.Count;
        }

        public void Add(string str)
        {
            this._custumers.Add(str);
            this._index += 1;
        }
        public IEnumerator GetEnumerator()
        {
            for(int i=0; i<this._index; i++)
                yield return this._custumers[i];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var listCustumers = new ListCustumers();
            listCustumers.Add("Mayardes");
            listCustumers.Add("Henrique");
            listCustumers.Add("Thayanne");
            listCustumers.Add("Wesley");
            listCustumers.Add("Juliana");

            for(int i=0; i<listCustumers.SizeList(); i++)
                System.Console.WriteLine(listCustumers[i]);

            System.Console.WriteLine("");
           foreach(var item in listCustumers)
                System.Console.WriteLine(item);


        }
    }
}
