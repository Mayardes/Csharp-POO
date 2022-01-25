using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_StructAndClass
{
    public class PositionClass
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return "X: " + X.ToString() + " Y: " + Y.ToString();
        }
    }

    public struct PositionStruct
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return "X: " + X.ToString() + " Y: " + Y.ToString();
        }
    }

    public enum RoleEnum: int
    {
        Architect,
        Developer,
        Tester
    }

    public enum ColorEnum: int
    {
        Red,
        Green,
        Orange,
        Black,
        White,
        Gray
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Reference types
            PositionClass pos1 = new PositionClass();
            pos1.X = 10;
            pos1.Y = 20;

            //Value types
            PositionStruct pos2 = new PositionStruct();
            pos2.X = 10;
            pos2.Y = 20;

            PositionStruct pos3 = pos2;
            pos2.X = 50;

            


            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine(pos3);
        }
    }
}
