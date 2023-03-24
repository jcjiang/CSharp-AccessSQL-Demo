using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }

    // The following configures EF to use SQL Server localdb
    // localdb must be installed first
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;");
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
}