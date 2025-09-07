namespace _04.MatrixShuffling;

internal class Program
{
    static void Main(string[] args)
    {
        int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];
        string[,] matrix = ReadRectangleMatrix(rows, cols);

        string input;
        while ((input = Console.ReadLine())!= "END")
        {
            string[] arguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            if ((arguments.Length != 5 || arguments[0] != "swap") ||
                (int.Parse(arguments[1]) < 0 || int.Parse(arguments[1]) > matrix.GetLength(0)) ||
                (int.Parse(arguments[2]) < 0 || int.Parse(arguments[2]) > matrix.GetLength(1)) ||
                (int.Parse(arguments[3]) < 0 || int.Parse(arguments[3]) > matrix.GetLength(0)) ||
                (int.Parse(arguments[4]) < 0 || int.Parse(arguments[4]) > matrix.GetLength(1)))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            string command = arguments[0];
            int row1 = int.Parse(arguments[1]);
            int col1 = int.Parse(arguments[2]);
            int row2 = int.Parse(arguments[3]);
            int col2 = int.Parse(arguments[4]);

            string backupValue = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = backupValue;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }

    static string[,] ReadRectangleMatrix(int rows, int cols)
    {
        string[,] matrix = new string[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        return matrix;
    }
}
