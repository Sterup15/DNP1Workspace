namespace Exercises._2._11;

class Program
{
    static void Main(string[] args)
    {
        Task<int> sumTask = Task.Run(() =>
        {
            Task.Delay(2000).Wait(); // Simulate work
            return 5 + 7;
        });

        int result = sumTask.Result;
        Console.WriteLine($"Sum: {result}");    
    }
}