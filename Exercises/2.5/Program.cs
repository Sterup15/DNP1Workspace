namespace _2._5;

internal class Program
{
    private static void Main(string[] args)
    {
        var person1 = new Person { Name = "Alice", Age = 25 };
        var person2 = new Person { Name = null, Age = null };

        person1.DisplayInfo();
        person2.DisplayInfo();
    }
}