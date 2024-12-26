using System;

namespace Project___1.Models;

public class BlogPost
{
    public required string Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}
