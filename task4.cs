using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[][] array1 = { new int[] { 1, 2 }, new int[] { 3, 4 } };
        int[][] array2 = { new int[] { 5, 6 }, new int[] { 7, 8 } };

        var matrixSumComparer = Comparer<int[]>.Create((x, y) =>
        {
            int sumX = x.Sum();
            int sumY = y.Sum();
            return Math.Abs(sumX - sumY);
        });
      
        var matrices = new[] { array1, array2 };

        Array.Sort(matrices, matrixSumComparer);

        Console.WriteLine("Sorted matrices by sum of elements:");
        
        foreach (var matrix in matrices)
        {
            Console.WriteLine(string.Join(", ", matrix));
        }
    }
}
