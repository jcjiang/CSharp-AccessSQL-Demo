using var db = new BloggingContext();

// Read
Console.WriteLine("Querying for blogs");

foreach (var blog in db.Blogs)
{
    Console.WriteLine(blog.Url);
}

