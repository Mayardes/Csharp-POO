using System;

namespace _34_TypeCasting
{
    public class Person
    {
        public string Name;
    }
    public class IndividualPerson : Person
    {
        public string CPF;
    }
    public class LegalPerson : Person
    {
        public string CNPJ;
    }

    public static class ReportPeople
    {
        public static void Print(Person person)
        {
            if(person is IndividualPerson)
                Console.WriteLine((person as IndividualPerson).Name);
            if(person is LegalPerson)
                Console.WriteLine((person as LegalPerson).Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var ip = new IndividualPerson()
            {
                CPF = "445211212",
                Name = "Matthew"
            };

            var lp = new LegalPerson()
            {
                CNPJ = "9498489/0001-2",
                Name = "Company INC"
            };

            ReportPeople.Print(ip);
            ReportPeople.Print(lp);
        }
    }
}
