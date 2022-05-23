using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack<int> stack = new StackToArray<int>(new int[] { 2, 10, 6 });


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
