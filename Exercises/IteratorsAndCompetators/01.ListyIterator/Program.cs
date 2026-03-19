namespace _01.ListyIterator;

public class Program
{
    static void Main(string[] args)
    {
        string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        ListyIterator<string> listy = new ListyIterator<string>(data.Skip(1));

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            try
            {
                if (command == "HasNext") Console.WriteLine(listy.HasNext());
                else if (command == "Move") Console.WriteLine(listy.Move());
                else if (command == "Print") Console.WriteLine(listy.Current);
                else if (command == "PrintAll") Console.WriteLine(string.Join(' ', listy));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
