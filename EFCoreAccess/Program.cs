using Microsoft.EntityFrameworkCore; //download Microsoft.EntityFrameworkCore.SqlServer

await using var db = new BloggingContext();

// Read
Console.WriteLine("Querying for blogs");

var results =
    from blog in await db.Blogs.ToListAsync()
    where blog.BlogId == 1
    select blog;

foreach (var s in results)
{
    Console.WriteLine("Blog id: " + s.BlogId + "    Blog URL: " + s.Url);
}