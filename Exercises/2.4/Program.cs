namespace _2._4;

class Program
{
    static void Main(string[] args)
    {
        int? userAge = null;
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int age))
        {
            userAge = age;
        }
        Console.WriteLine($"Your age is: {userAge ?? 18}");
    }
}