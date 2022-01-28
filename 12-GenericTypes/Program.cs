namespace _12_GenericTypes
{
    public class Stack<T>
    {
        int pos = 0;
        T[] p = new T[10];
        public void Push(T item)
        {
            p[pos] = item;
            pos++;
        }

        public T Pop()
        {
            pos--;
            return p[pos];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack1 = new Stack<string>();
            stack1.Push("arg1");
            stack1.Push("arg2");
            stack1.Push("arg3");
            stack1.Pop();
            stack1.Pop();
            stack1.Pop();

            var stack2 = new Stack<bool>();
            stack2.Push(false);
            stack2.Push(true);

            stack2.Pop();
            stack2.Pop();




        }
    }
}
