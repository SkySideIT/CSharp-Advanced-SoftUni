/*
 Model: a string property
 Engine: a property holding the engine object
 Weight: an int property, it is optional
 Color: a string property, it is optional 
*/

using System.Text;

namespace _08.CarSalesman;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public int? Weight { get; set; }
    public string? Color { get; set; }

    public Car(string model, Engine engine, int? weight, string? color)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = weight;
        this.Color = color;
    }

    public override string ToString()
    {
        StringBuilder resultBuilder = new StringBuilder();

        resultBuilder.AppendLine($"{this.Model}:");
        resultBuilder.AppendLine(this.Engine.ToString());
        resultBuilder.AppendLine($"  Weight: {this.Weight?.ToString() ?? "n/a"}");
        resultBuilder.Append($"  Color: {this.Color ?? "n/a"}");

        return resultBuilder.ToString();
    }
}
