/*
5
10 20 30
1 2 3
2
2
10 10
Add 0 10 10
Add 0 0 10
Subtract -3 0 10
Subtract 3 0 10
End
 
 */


namespace _06.JaggedArrayManipulator;

internal class Program
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());

        double[][] matrix = new double[rows][];

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        }
        
        for (int i = 1; i < rows; i++)
        {
            double multiplier;
            if (matrix[i - 1].Length == matrix[i].Length) multiplier = 2;
            else multiplier = 0.5;

            for (int j = 0; j < matrix[i - 1].Length; j++)
            {
                matrix[i - 1][j] *= multiplier;
            }

            for(int j = 0;j < matrix[i].Length; j++)
            {
                matrix[i][j] *= multiplier;
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split();
            string command = arguments[0];
            int row = int.Parse(arguments[1]);
            int col = int.Parse(arguments[2]);
            double value = double.Parse(arguments[3]);

            if((row < 0 || row > matrix.Length) || (col < 0 || col > matrix[row].Length))
            {
                continue;
            }

            if (command == "Add")
            {
                matrix[row][col] += value;
            }
            else if (command == "Subtract")
            {
                matrix[row][col] -= value;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(string.Join(" ", matrix[i]));
        }
    }
}
