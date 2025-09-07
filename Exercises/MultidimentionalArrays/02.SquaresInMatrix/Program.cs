
namespace _02.SquaresInMatrix;

internal class Program
{
    static void Main(string[] args)
    {
        int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];
        char[,] matrix = ReadRectangleMatrix(rows, cols);
        int result = CountEqualSubSquares(matrix);
        Console.WriteLine(result);
    }

    static int CountEqualSubSquares(char[,] matrix)
    {
        int count = 0;

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1] && 
                    matrix[i, j] == matrix[i + 1, j] &&
                    matrix[i, j] == matrix[i + 1, j + 1])
                {
                    count++;
                }
            }
        }

        return count;
    }

    static char[,] ReadRectangleMatrix(int rows, int cols)
    {
        char[,] matrix = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            char[] symbols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = symbols[j];
            }
        }

        return matrix;
    }
}
