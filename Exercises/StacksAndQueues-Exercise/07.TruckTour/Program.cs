namespace _07.TruckTour;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Queue<(int fuel, int kilometres)> stations = new Queue<(int fuel, int kilometres)>();
        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int fuel = input[0], kilometres = input[1];

            stations.Enqueue( (fuel, kilometres) );
        }

        for (int i = 0; i < n; i++)
        {
            int fuelAmount = 0;
            bool success = true;

            foreach (var (fuel, kilometres) in stations)
            {
                fuelAmount += fuel;

                if (fuelAmount < kilometres)
                {
                    success = false;
                    break;
                }

                fuelAmount -= kilometres;
            }

            if (success)
            {
                Console.WriteLine(i);
                break;
            }
            else
            {
                stations.Enqueue(stations.Dequeue());
            }
        }
    }
}
