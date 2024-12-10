using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int[][] matrix1 = { new int[] { 1, 2 }, new int[] { 3, 4 } };
        int[][] matrix2 = { new int[] { 5, 6 }, new int[] { 7, 8 } };
        int[][] matrix3 = { new int[] { 10, 20 }, new int[] { 30, 40 } };

        
        var matrixSumComparer = Comparer<int[]>.Create((x, y) =>
        {
            int sumX = x.Sum();
            int sumY = y.Sum();
            return Math.Abs(sumX - sumY);
        });

      
        var matrices = new[] { matrix1, matrix2, matrix3 };

        
        Array.Sort(matrices, matrixSumComparer);

        Console.WriteLine("Sorted matrices by sum of elements:");
        
        foreach (var matrix in matrices)
        {
            Console.WriteLine(string.Join(", ", matrix));
            Console.WriteLine($"Sum: {matrix.Sum()}");
            Console.WriteLine();
        }
    }
}
