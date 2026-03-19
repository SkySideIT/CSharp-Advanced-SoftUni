using System;

namespace _05.ComparingObjects;

public class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Person person = new Person(data[0], int.Parse(data[1]), data[2]);
            people.Add(person);
        }

        int position = int.Parse(Console.ReadLine());
        Person requestedPerson = people[position - 1];

        int matches = 0;
        foreach (Person person in people)
        {
            if (Comparer<Person>.Default.Compare(requestedPerson, person) == 0)
            {
                matches++;
            }
        }

        if (matches == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
        }
    }
}
