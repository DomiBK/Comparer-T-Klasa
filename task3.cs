using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int result = CompareStringLength(str1, str2);

        switch (result)
        {
            case -1:
                Console.WriteLine($"{str1} is shorter than {str2}");
                break;
            case 1:
                Console.WriteLine($"{str1} is longer than {str2}");
                break;
            case 0:
                Console.WriteLine($"Both strings have equal length");
                break;
            default:
                Console.WriteLine("Invalid result");
                break;
        }
    }

    static int CompareStringLength(string x, string y)
    {
        return Math.Abs(x.Length - y.Length);
    }
}
