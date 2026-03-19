
namespace _05.ComparingObjects;

public class Person : IComparable<Person>
{
    private readonly string _name;
    private readonly int _age;
    private readonly string _town;

    public Person(string name, int age, string town)
    {
        this._name = name;
        this._age = age;
        this._town = town;
    }

    public int CompareTo(Person? other)
    {
        if (other == null) return 1;

        int nameComparison = Comparer<string>.Default.Compare(this._name, other._name);
        if (nameComparison != 0 ) return nameComparison;

        int ageComparison = Comparer<int>.Default.Compare(this._age, other._age);
        if (ageComparison != 0 ) return ageComparison;

        int townComparison = Comparer<string>.Default.Compare(this._town, other._town);
        return townComparison;
    }
}
