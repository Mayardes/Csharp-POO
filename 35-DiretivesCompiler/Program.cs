#define OK
using System;

namespace _35_DiretivesCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
#if (OK)
            Console.WriteLine("OK");
#elif OK
            Console.WriteLine("OK2");
#endif
        }
    }
}
