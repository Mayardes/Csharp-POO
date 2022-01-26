using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_PartialClass
{
    public partial class User
    {
        private int _code { get; set; }
        private string _name { get; set; }
        private string _password { get; set; }

        public User(int code, string name, string password)
        {
            _code = code;
            _name = name;
            _password = password;
        }
    }

    public partial class User
    {
        public string  GetName()
        {
            return this._name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(122, "Mayardes", "123");
            Console.WriteLine(user.GetName());
        }
    }
}
