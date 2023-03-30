using System;
namespace Section_7
{
	class Challenge_10_Stack
	{
		static void Main(string[] args)
		{
			Stack<int> stack = new Stack<int>();

			stack.Push(1);
			Console.WriteLine($"Top value in the stack is : {stack.Peek()}");
			stack.Push(2);
            Console.WriteLine($"Top value in the stack is : {stack.Peek()}");
            stack.Push(3);
            Console.WriteLine($"Top value in the stack is : {stack.Peek()}");

            while(stack.Count > 0)
			{
                Console.WriteLine($"Top value was removed from the stack: {stack.Pop()}");
                Console.WriteLine($"Current stack is : {stack.Count}");
            }
        }


	}
}

