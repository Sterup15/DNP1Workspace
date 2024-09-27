using _4._09;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace _4._10;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        var posts = new List<Post>
        {
            new Post { Id = 1, UserId = 1, Title = "Post 1", Body = "Body of Post 1" },
            new Post { Id = 2, UserId = 1, Title = "Post 2", Body = "Body of Post 2" }
        };

        // GET endpoint to retrieve all posts
        app.MapGet("/posts", () => posts);

        // GET endpoint to retrieve a specific post by ID
        app.MapGet("/posts/{id:int}", (int id) =>
        {
            var post = posts.FirstOrDefault(p => p.Id == id);
            return post is not null ? Results.Ok(post) : Results.NotFound("Post not found");
        });

        // POST endpoint to add a new post
        app.MapPost("/posts", (Post newPost) =>
        {
            newPost.Id = posts.Max(p => p.Id) + 1; // Assign a new ID
            posts.Add(newPost);
            return Results.Created($"/posts/{newPost.Id}", newPost);
        });

        app.Run();
    }
}