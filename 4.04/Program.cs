namespace _4._04;

class Program
{
    static void Main(string[] args)
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = client.GetAsync("https://jsonplaceholder.typicode.com/posts/").Result;
        Console.WriteLine(response.Content.ReadAsStringAsync().Result);
    }
}