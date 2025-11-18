/*
Peter Misha Stephen
Remove StartsWith P
Double Length 5
Party!
 
 */


namespace _09.PredicateParty;

internal class Program
{
    static void Main(string[] args)
    {
        // command => (arg, name) => bool
        Dictionary<string, Func<string, string, bool>> filtersMap = new Dictionary<string, Func<string, string, bool>>
        {
            ["StartsWith"] = (arg, name) => name.StartsWith(arg),
            ["EndsWith"] = (arg, name) => name.EndsWith(arg),
            ["Length"] = (arg, name) => name.Length.ToString() == arg
        };

        string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string command;
        while ((command = Console.ReadLine()) != "Party!")
        {
            string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string operation = data[0], filterName = data[1], filterArg = data[2];

            Func<string, string, bool> filter = filtersMap[filterName];

            List<string> people;

            if (operation == "Remove")
            {
                people = RemoveAll(names, x => filter(filterArg, x));
            }
            else if (operation == "Double")
            {
                people = Duplicate(names, x => filter(filterArg, x));
            }
            else
            {
                throw new InvalidOperationException("Invalid operation.");
            }

            names = people.ToArray();
        }

        if (names.Length == 0)
        {
            Console.WriteLine("Nobody is going to the party!");
        }
        else Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
    }

    static List<string> Duplicate(string[] array, Func<string, bool> conditions)
    {
        List<string> result = new List<string>();

        for (int i = 0; i < array.Length; i++)
        {
            if (conditions(array[i]))
            {
                result.Add(array[i]);
            }

            result.Add(array[i]);
        }

        return result;
    }

    static List<string> RemoveAll(string[] array, Func<string, bool> conditions)
    {
        List<string> result = new List<string>();

        for (int i = 0; i < array.Length; i++)
        {
            if (!conditions(array[i]))
            {
                result.Add(array[i]);
            }
        }

        return result;
    }
}
