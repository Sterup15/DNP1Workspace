using Microsoft.AspNetCore.Builder;

namespace _4._07;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        // Test GET endpoint
        app.MapGet("/", () => "Hello, Minimal API!");

        app.Run();
    }
}