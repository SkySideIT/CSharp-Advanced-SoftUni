/*
2
ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4
Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1
fragile
 
 */


namespace _07.RawData;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Car[] cars = new Car[n];
        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = data[0];
            Engine engine = new Engine(int.Parse(data[1]), int.Parse(data[2]));
            Cargo cargo = new Cargo(int.Parse(data[3]), data[4]);
            Tire tire1 = new Tire(double.Parse(data[5]), int.Parse(data[6]));
            Tire tire2 = new Tire(double.Parse(data[7]), int.Parse(data[8]));
            Tire tire3 = new Tire(double.Parse(data[9]), int.Parse(data[10]));
            Tire tire4 = new Tire(double.Parse(data[11]), int.Parse(data[12]));

            cars[i] = new Car
            { 
                Model = model,
                Cargo = cargo,
                Engine = engine,
                Tires = new[] { tire1, tire2, tire3, tire4 } };
        }

        string command = Console.ReadLine();

        Func<Car, bool> filter = command switch
        {
            "fragile" => c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1),
            "flammable" => c => c.Cargo.Type == "flammable" && c.Engine.Power > 250,
            _ => throw new InvalidOperationException("Invalid command!")
        };

        foreach (Car car in cars.Where(filter))
        {
            Console.WriteLine(car.Model);
        }
    }
}
