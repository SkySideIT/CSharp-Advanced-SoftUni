/*
2
V8-101 220 50
V4-33 140 28 B
3
FordFocus V4-33 1300 Silver
FordMustang V8-101
VolkswagenGolf V4-33 Orange
 
 */

using System.Text;

namespace _08.CarSalesman;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Engine> enginesByModel = new Dictionary<string, Engine>();

        int numOfEngine = int.Parse(Console.ReadLine());

        for (int i = 0; i < numOfEngine; i++)
        {
            string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = data[0];
            int power = int.Parse(data[1]);
            int? displacement = null;
            string? efficiency = null;

            if (data.Length == 3)
            {
                if (int.TryParse(data[2], out int numericValue)) displacement = numericValue;
                else efficiency = data[2];
            }
            else if (data.Length == 4)
            {
                displacement = int.Parse(data[2]);
                efficiency = data[3];
            }

            Engine engine = new Engine(model, power, displacement, efficiency);
            enginesByModel[model] = engine;
        }

        int numOfCars = int.Parse(Console.ReadLine());

        Car[] cars = new Car[numOfCars];
        for (int i = 0; i < numOfCars; i++)
        {
            string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = data[0];
            Engine engine = enginesByModel[data[1]];
            int? weight = null;
            string? color = null;

            if (data.Length == 3)
            {
                if (int.TryParse(data[2], out int numericValue)) weight = numericValue;
                else color = data[2];
            }
            else if (data.Length == 4)
            {
                weight = int.Parse(data[2]);
                color = data[3];
            }

            cars[i] = new Car(model, engine, weight, color);
        }

        StringBuilder sb = new StringBuilder();

        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
