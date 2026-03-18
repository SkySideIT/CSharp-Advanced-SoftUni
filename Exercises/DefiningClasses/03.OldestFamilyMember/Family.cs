
namespace _03.OldestFamilyMember;

internal class Family
{
    private readonly List<Person> members = new List<Person>();
    public void AddMember(Person person)
    {
        members.Add(person);
    }

    public Person GetOldestMember()
    {
        return this.members.MaxBy(x => x.Age);
    }
}
