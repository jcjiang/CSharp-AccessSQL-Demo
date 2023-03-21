using System;
using System.Linq;

using var db = new BloggingContext();

// Read
Console.WriteLine("Querying for a blog");
var blog = db.Blogs
    .First();

Console.WriteLine(blog.Url);
