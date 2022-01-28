using System;

namespace _13_NamedParemeter
{
    public class DialogBox
    {
        public void MessageBox(string message, bool isActive, int position)
        {
            Console.WriteLine(message + isActive + position);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DialogBox dialogBox = new DialogBox();
            dialogBox.MessageBox(isActive: true, position: 1, message: "hello");
        }
    }
}
