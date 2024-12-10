class Program
{
    static void Main()
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"Original numbers: {num1}, {num2}");
        
        
        int result = CompareNumbers(num2, num1);
        
        Console.WriteLine($"Compared in reverse order: {num2} -> {num1} = {result}");
    }

    static int CompareNumbers(int a, int b)
    {
        return b.CompareTo(a);
    }
}
