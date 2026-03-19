namespace _03.Stack;

public class Program
{
    static void Main(string[] args)
    {
        CustomStack<int> stack = new();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] tokens = command
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string action = tokens[0];

            if (action == "Push")
            {
                int[] itemsToPush = tokens
                    .Skip(1)
                    .Select(int.Parse)
                    .ToArray();

                foreach (var item in itemsToPush)
                {
                    stack.Push(item);
                }
            }
            else
            {
                try
                {
                    stack.Pop();
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
