using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }

    // The following configures EF to use SQL Server localdb
    // localdb must be installed first
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options
            .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;")
            .LogTo(Console.WriteLine, LogLevel.Information); // Logs SQL queries to console
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}
