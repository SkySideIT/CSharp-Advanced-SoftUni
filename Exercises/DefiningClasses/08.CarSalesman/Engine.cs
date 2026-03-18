/*
 Model: a string property
 Power: an int property
 Displacement: an int property, it is optional
 Efficiency: a string property, it is optional 
*/

using System.Text;

namespace _08.CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int? Displacement { get; set; }
        public string? Efficiency { get; set; }

        public Engine(string model, int power, int? displacement, string? efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public override string ToString()
        {
            StringBuilder resultBuilder = new StringBuilder();

            resultBuilder.AppendLine($"  {this.Model}:");
            resultBuilder.AppendLine($"    Power: {this.Power}");
            resultBuilder.AppendLine($"    Displacement: {this.Displacement?.ToString() ?? "n/a"}");
            resultBuilder.Append($"    Efficiency: {this.Efficiency ?? "n/a"}");

            return resultBuilder.ToString();
        }
    }
}