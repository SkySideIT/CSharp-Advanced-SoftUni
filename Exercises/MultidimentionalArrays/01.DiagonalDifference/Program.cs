namespace _01.DiagonalDifference;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = ReadSquareMatrix(n);
        int result = Math.Abs(CalculatePrimaryDiagonalSum(matrix) - CalculateSecondaryDiagonalSum(matrix));
        Console.WriteLine(result);
    }

    static int CalculateSecondaryDiagonalSum(int[,] matrix)
    {
        int minDimention = Math.Min(matrix.GetLength(0), matrix.GetLength(1));

        int sum = 0;
        for (int i = 0; i < minDimention; i++)
        {
            sum += matrix[i, matrix.GetLength(1) - 1 - i];
        }

        return sum;
    }

    static int CalculatePrimaryDiagonalSum(int[,] matrix)
    {
        int minDimention = Math.Min(matrix.GetLength(0), matrix.GetLength(1));

        int sum = 0;
        for (int i = 0; i < minDimention; i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }

    static int[,] ReadSquareMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = nums[j];
            }
        }

        return matrix;
    }
}
