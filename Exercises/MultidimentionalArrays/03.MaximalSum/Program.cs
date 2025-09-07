/*
4 5
1 5 5 2 4
2 1 4 14 3
3 7 11 2 8
4 8 12 16 4
 
 */


namespace _03.MaximalSum;

internal class Program
{
    static void Main(string[] args)
    {
        int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];
        int[,] matrix = ReadRectangleMatrix(rows, cols);

        int maxSum = int.MinValue;
        int maxRowIndex = -1;
        int maxColIndex = -1;

        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                int currentSum = CalculateSumInRange(matrix, i, j, 3, 3);

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxRowIndex = i;
                    maxColIndex = j;
                }
            }
        }

        Console.WriteLine($"Sum = {maxSum}");
        for (int i = maxRowIndex; i < maxRowIndex + 3; i++)
        {
            for (int j = maxColIndex; j < maxColIndex + 3; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }
    }

    static int CalculateSumInRange(int[,] matrix, int row, int col, int height, int width)
    {
        int sum = 0;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                sum += matrix[row + i, col + j];
            }
        }

        return sum;
    }

    static int[,] ReadRectangleMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            int[] symbols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = symbols[j];
            }
        }

        return matrix;
    }
}
