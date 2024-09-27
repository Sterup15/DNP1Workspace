internal class Program
{
    public static void Main(string[] args)
    {
        List<string> studentNames = new List<string>();
            
        studentNames.Add("Alice");
        studentNames.Add("Bob");
        studentNames.Add("Charlie");
        studentNames.Add("Diana");
        studentNames.Add("Eve");

        for (int i = 0; i < studentNames.Count; i++)
        {
            Console.WriteLine(studentNames[i]);
        }
        
        
        Console.WriteLine("Enter a name to add it to the list");
        studentNames.Add(Console.ReadLine());
        
        studentNames.Sort();
        Console.WriteLine("Sorted List: " + string.Join(", ", studentNames));

        studentNames.Remove("Bob");
        Console.WriteLine("Sorted List after removing Bob " + string.Join(", ", studentNames));
        
    }
}