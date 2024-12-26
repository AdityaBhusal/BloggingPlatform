using System;
using System.Buffers.Text;
using Microsoft.EntityFrameworkCore;
using Project___1.Models;

namespace Project___1.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
    public DbSet<BlogPost> BlogPosts { get; set; }
}
