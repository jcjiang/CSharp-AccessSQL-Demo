using Microsoft.EntityFrameworkCore;

await using var db = new BloggingContext();

// Read
Console.WriteLine("Querying for blogs");

var queryBlog =
    from blog in await db.Blogs.ToListAsync()
    where blog.Url == blog.BlogId == 1
    select blog;

foreach (var s in queryBlog)
{
    Console.WriteLine(s.Url);
}