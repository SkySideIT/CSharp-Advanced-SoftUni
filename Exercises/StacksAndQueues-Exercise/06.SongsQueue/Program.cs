namespace _06.SongsQueue;

internal class Program
{
    static void Main(string[] args)
    {
        Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));

        while (songs.Count > 0)
        {
            string input = Console.ReadLine();
            if (input == "Play")
            {
                songs.Dequeue();
            }
            else if (input.StartsWith("Add"))
            {
                string song = input.Substring(4);
                if (!songs.Contains(song))
                {
                    songs.Enqueue(song);
                }
                else
                {
                    Console.WriteLine($"{song} is already contained!");
                }
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", songs)}");
            }
        }

        if (songs.Count == 0)
        {
            Console.WriteLine("No more songs!");
        }
    }
}
