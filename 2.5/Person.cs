namespace _2._5;

public class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name ?? "No Name"}");
        Console.WriteLine($"Age: {Age?.ToString() ?? "No Age"}");
    }
}