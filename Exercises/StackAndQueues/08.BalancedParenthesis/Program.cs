namespace _08.BalancedParenthesis;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        if (IsBalanced(input))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    static bool IsBalanced(string input)
    {
        Dictionary<char, char> symbolsMap = new Dictionary<char, char>
        {
            ['('] = ')',
            ['{'] = '}',
            ['['] = ']'
        };

        Stack<char> stack = new Stack<char>();

        foreach (char symbol in input)
        {
            if (symbolsMap.ContainsKey(symbol))
            {
                stack.Push(symbolsMap[symbol]);
            }
            else
            {
                if (stack.Count == 0 || stack.Peek() != symbol)
                {
                    return false;
                }
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}
