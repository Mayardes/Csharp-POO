using System;
using MOliveira.Util.Funcoes;

namespace _36_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Guid: {GenerateGuid.NewGuid()} \nDate: {GenerateDate.GenerateDateTime()}");
        }
    }
}
