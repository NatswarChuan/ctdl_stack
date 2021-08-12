using System;
using System.Collections.Generic;

namespace StackList
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.WriteLine("Push: 1 2 3 1");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(1);
            stack.Show();

            Console.WriteLine($"Peek: {stack.Peek()}");
            
            Console.WriteLine($"Pop: {stack.Pop()}");
            stack.Show();

            Console.WriteLine($"Find: {stack.Find(1).Value}");

            Console.WriteLine($"FindLast: {stack.FindLast(1).Value}");

            Console.WriteLine("Bubble Sort:");
            stack.BubbleSort();
            stack.Show();

            Console.WriteLine("Interchange Sort:");
            stack.InterchangeSort();
            stack.Show();

        }
    }
}
