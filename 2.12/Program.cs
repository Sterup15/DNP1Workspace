namespace _2._12;

internal class Program
{
    private static async Task Main(string[] args)
    {
        async Task<string> GetMessageAsync()
        {
            await Task.Delay(2000); // Simulate work
            return "Hello, Async!";
        }
        
        var message = await GetMessageAsync();
        Console.WriteLine(message);
    }
}