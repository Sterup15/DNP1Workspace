using Microsoft.AspNetCore.Builder;

namespace _4._08;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        // In-memory list of posts
        var posts = new List<Post>
        {
            new Post { Id = 1, UserId = 1, Title = "Post 1", Body = "Body of Post 1" },
            new Post { Id = 2, UserId = 1, Title = "Post 2", Body = "Body of Post 2" }
        };

        // GET endpoint to retrieve all posts
        app.MapGet("/posts", () => posts);

        app.Run();
    }
}