using System.Collections.Generic;
using System;

namespace _32_Stack
{
    public class Document
    {
        public int Code;
        public string Type;
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var doc1 = new Document(){ Code = 1, Type = ".docx", Name = "exemple1"};
            var doc2 = new Document(){ Code = 2, Type = ".docx", Name = "exemple2"};
            var doc3 = new Document(){ Code = 3, Type = ".docx", Name = "exemple3"};


            var stack = new Stack<Document>();
            stack.Push(doc1);
            stack.Push(doc2);
            stack.Push(doc3);

            stack.Pop();

            var obj = stack.Peek();

            Console.WriteLine(obj.Name);

            foreach(Document item in stack)
                Console.WriteLine(item.Name);
            
        }
    }
}
