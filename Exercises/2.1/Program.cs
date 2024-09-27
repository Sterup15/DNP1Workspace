namespace Exercises._2._1;

internal class Program
{
    private static void Main(string[] args)
    {
        Func<int, int, int> add = (a, b) => a + b;
        Func<int, int, int> multiply = (a, b) => a * b;

        var num1 = int.Parse(Console.ReadLine()!);
        var num2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine(add(num1, num2));
        Console.WriteLine(multiply(num1, num2));
    }
}