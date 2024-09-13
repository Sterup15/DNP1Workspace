namespace _2._10;

class Program
{
    static void Main(string[] args)
    {
        Task myTask = Task.Run(() =>
        {
            Console.WriteLine("Task started");
            Task.Delay(3000);
            Console.WriteLine("Task finished");
        });

        myTask.Wait();
    }
}