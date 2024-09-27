namespace Exercise3._03;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>()
        {
            10, 23, 35, 42, 56, 67, 72, 89, 91, 100
        };
        
        Console.WriteLine("Original List: " + string.Join(", ", numbers));

        IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

        IEnumerable<int> evenNumbersOverFifty = evenNumbers.Where(n => n > 50).ToList();
        Console.WriteLine("Even numbers over fifty: " + string.Join(", ", evenNumbersOverFifty));
    }
}