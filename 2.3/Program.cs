namespace _2._3;

class Program
{
    static void Main(string[] args)
    {
        List<int> scores = new List<int> { 85, 67, 92, 45, 76, 88, 59 };

        var filteredScores = scores
            .Where(score => score >= 70)
            .Select(score => $"{score}: Pass");

        Console.WriteLine("Filtered and processed scores:");
        foreach (var result in filteredScores)
        {
            Console.WriteLine(result);
        }
    }
}