namespace _06.SpeedRacing;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Car> carsByModel = new Dictionary<string, Car>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = new Car 
            { 
                Model = data[0],
                FuelAmount = double.Parse(data[1]),
                FuelConsumptionPerKilometer = double.Parse(data[2]),
                TravelledDistance = 0
            };

            carsByModel[car.Model] = car;
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = data[1];
            double distanceInKm = double.Parse(data[2]);

            Car car = carsByModel[model];

            if (!car.Drive(distanceInKm))
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        foreach (Car currentCar in carsByModel.Values)
        {
            Console.WriteLine($"{currentCar.Model} {currentCar.FuelAmount:f2} {currentCar.TravelledDistance}");
        }
    }
}
