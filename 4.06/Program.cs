﻿using System.Text;

namespace _4._06;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        string jsonData = "{\"title\": \"foo\", \"body\": \"bar\", \"userId\": 1}";
        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PutAsync("https://jsonplaceholder.typicode.com/posts/1", content);
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Status Code: {response.StatusCode}");
        Console.WriteLine($"Response Body: {responseBody}");
    }
}