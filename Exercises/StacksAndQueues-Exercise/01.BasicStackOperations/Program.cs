namespace _01.BasicStackOperations;

internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0], s = input[1], x = input[2];

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            stack.Push(numbers[i]);
        }

        for (int i = 0; i < s; i++)
        {
            stack.Pop();
        }

        if (stack.Count == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            bool isFound = false;
            foreach (int num in stack)
            {
                if (num == x)
                {
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine(stack.Min());
        }
    }
}
