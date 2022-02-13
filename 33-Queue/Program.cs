using System.Collections.Generic;
using System;

namespace _33_Queue
{
    public class AccountHolder
    {
        public string Agency;
        public string Account;
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var accountHolder1 = new AccountHolder() { Agency = "123", Account = "456", Name = "Mayardes"};
            var accountHolder2 = new AccountHolder() { Agency = "456", Account = "789", Name = "Oliveira"};
            var accountHolder3 = new AccountHolder() { Agency = "321", Account = "654", Name = "Matthew"};
            var accountHolder4 = new AccountHolder() { Agency = "852", Account = "963", Name = "Eduarda"};

            var queue = new Queue<AccountHolder>();

            queue.Enqueue(accountHolder1);
            queue.Enqueue(accountHolder2);
            queue.Enqueue(accountHolder3);
            queue.Enqueue(accountHolder4);

            //Remove one element from queue
            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine("Account holders waiting on queue:");
            foreach(var item in queue)
                Console.WriteLine(item.Name);

            Console.WriteLine("Press a key for call Account holder");
            Console.ReadKey();
            Console.WriteLine(queue.Peek().Name);

            Console.WriteLine("");
            



        }
    }
}
