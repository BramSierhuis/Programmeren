using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        void Start()
        {
            IStack myStack = new ArrayStack(50);
            AddValues(myStack);

            CheckValue(3, myStack);
            CheckValue(5, myStack);
            CheckValue(4, myStack);

            ProcessValues(myStack);
        }

        void AddValues(IStack stack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int value = rnd.Next(10);
                stack.Push(value);
                Console.WriteLine($"pushed {value}, new count: { stack.Count}");
            }
        }

        void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value}, new count: {stack.Count}");
            }
        }

        void CheckValue(int value, IStack stack)
        {
            if (stack.Contains(value))
                Console.WriteLine("The stack contains " + value);
            else
                Console.WriteLine("The stack doesn't contain " + value);
        }
    }
}
