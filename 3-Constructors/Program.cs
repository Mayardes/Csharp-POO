using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructors
{
    public class Custumer
    {
        public int Code;
        public string Name;
        public Contact Contact;

        public Custumer()
        {
            this.Contact = new Contact();
        }

        public Custumer(int code):this()
        {
            this.Code = code;
        }

        public Custumer(string name, int code): this(code)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Code: " + Code);
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("TypeContact:" + Contact.TypeContact);
            sb.AppendLine("DescriptionContact:" + Contact.Description);

            return sb.ToString();
        }
    }

    public class CustumerVIP : Custumer
    {
        public int Time;

        public CustumerVIP(string name, int code):base(name, code)
        {
            this.Time = 10;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Code: " + Code);
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Time: " + Time);
            sb.AppendLine("TypeContact:" + Contact.TypeContact);
            sb.AppendLine("DescriptionContact:" + Contact.Description);

            return sb.ToString();
        }
    }
    public class Contact
    {
        public string TypeContact;
        public string Description;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Custumer custumer = new Custumer();
            custumer.Code = 123;
            custumer.Name = "Mayardes";
            custumer.Contact.TypeContact = "Phone";
            custumer.Contact.Description = "92 98452-7316";

            Console.WriteLine(custumer);

            ///derivative class
            Custumer custumerVip = new CustumerVIP("Mayardes",123);
            Console.WriteLine(custumerVip);

        }
    }
}
