﻿namespace _03.MaximumAndMinimumElement;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int command = input[0];

            if (command == 1)
            {
                stack.Push(input[1]);
            }
            else if (command == 2)
            {
                stack.Pop();
            }
            else if (command == 3)
            {
                Console.WriteLine(stack.Max());
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }

        Console.WriteLine(string.Join(", ", stack));
    }
}
