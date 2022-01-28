using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_IndexProperties
{
    public class Products
    {
        private List<string> _itens = new List<string>();

        public Products()
        {
            this._itens = new List<string>();
        }

        public void Add(string item)
        {
            this._itens.Add(item);
        }

        public string Get(int index)
        {
            return _itens[index];
        }

        //index properties

        public string this[int index]
        {
            get { return this._itens[index]; }
        }

        public int this[string name]
        {
            get { return this._itens.IndexOf(name); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();
            products.Add("Cellphone");
            products.Add("Notebook");
            products.Add("Mouse");

            Console.WriteLine(products[0]);
            Console.WriteLine(products[1]);
            Console.WriteLine(products[2]);
            Console.WriteLine(products["Notebook"]);

        }
    }
}
