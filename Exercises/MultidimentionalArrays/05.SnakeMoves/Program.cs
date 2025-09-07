namespace _05.SnakeMoves;

internal class Program
{
    static void Main(string[] args)
    {
        int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];
        string word = Console.ReadLine();

        char[][] matrix = new char[rows][];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i] = new char[cols];
            }
        }

        int pos = 0;

        for (int row = 0; row < rows; row++)
        {
            for(int j = 0; j < cols; j++)
            {
                int col;
                if (row % 2 == 0)
                {
                    col = j;
                }
                else
                {
                    col = cols - (j + 1);
                }

                matrix[row][col] = word[pos];
                pos = (pos + 1) % word.Length;
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            Console.WriteLine(matrix[i]);
        }
    }
}
