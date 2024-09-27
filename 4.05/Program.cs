using System.Text;

namespace _4._05;

class Program
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();
        string jsonData = "{\"title\": \"foo\", \"body\": \"bar\", \"userId\": 1}";
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PostAsync("https://jsonplaceholder.typicode.com/posts", content);
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Status Code: {response.StatusCode}");
        Console.WriteLine($"Response Body: {responseBody}");
    }
}