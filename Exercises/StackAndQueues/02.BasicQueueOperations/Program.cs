namespace _02.BasicQueueOperations;

internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0], s = input[1], x = input[2];

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < n; i++)
        {
            queue.Enqueue(numbers[i]);
        }

        for (int i = 0; i < s; i++)
        {
            queue.Dequeue();
        }

        if (queue.Count == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            bool isFound = false;
            foreach (int num in queue)
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
            else Console.WriteLine(queue.Min());
        }
    }
}
