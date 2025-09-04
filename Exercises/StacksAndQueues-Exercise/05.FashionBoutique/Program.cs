namespace _05.FashionBoutique;

internal class Program
{
    static void Main(string[] args)
    {
        Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        int rackCapacity = int.Parse(Console.ReadLine());

        int rackCapacityLeft = 0;
        int racks = 0;

        while (clothes.Count > 0)
        {
            if (clothes.Peek() > rackCapacityLeft)
            {
                racks++;
                rackCapacityLeft = rackCapacity;
                rackCapacityLeft -= clothes.Pop();
            }
            else
            {
                rackCapacityLeft -= clothes.Pop();
            }
        }

        Console.WriteLine(racks);
    }
}
