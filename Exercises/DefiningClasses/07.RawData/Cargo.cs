namespace _07.RawData;

public class Cargo
{
    public string Type { get; set; }
    public int Weight { get; set; }

    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type ?? throw new ArgumentNullException(nameof(type));
    }
}