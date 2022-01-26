using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_StaticClass
{
    public static class ConverterStatic
    {
        public static double CelsiusToFah(double temp)
        {
            return (temp * 9 / 5) + 32;
        }
        public static double FahToCelsius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }

    public class ConverterInstance
    {
        //only this attribute is static. Belong my class 
        public static double temp;
        public double CelsiusToFah()
        {
            return (temp * 9 / 5) + 32;
        }
        public double FahToCelsius()
        {
            return (temp - 32) * 5 / 9;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var temp = 35;

            var tempFah = ConverterStatic.CelsiusToFah(temp);
            Console.WriteLine("Fah: " + tempFah);

            var tempCelsius = ConverterStatic.FahToCelsius(tempFah);
            Console.WriteLine("Cel: " + tempCelsius);

            Console.WriteLine();

            var instanceConverter = new ConverterInstance();

            ConverterInstance.temp = 35;
            tempFah = instanceConverter.CelsiusToFah();
            ConverterInstance.temp = tempFah;
            tempCelsius = instanceConverter.FahToCelsius();

            Console.WriteLine("Fah: " + tempFah);
            Console.WriteLine("Cel: " + tempCelsius);


        }
    }
}
