using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDatabaseAccesser.Dapper
{
    public class BlogData
    {
        private readonly DapperSQLAccess _db;

        public BlogData(DapperSQLAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Blog>> GetBlogs()
        {
            return _db.loadData<Blog, dynamic>(storedProcedure: "dbo.spBlog_GetAll", new { });
        }

        public async Task<Blog?> GetBlog(int BlogId)
        {
            var results = await _db.loadData<Blog, dynamic>(
                storedProcedure: "dbo.spBlog_Get",
                new { BlogId });
            return results.FirstOrDefault();
        }

        public Task InsertBlog(Blog blog)
        {
            return _db.SaveData(storedProcedure: "dbo.spBlog_Insert", new { blog.Url });
        }

        public Task UpdateBlog(Blog blog)
        {
            return _db.SaveData(storedProcedure: "dbo.spBlog_Update", blog);
        }

        public Task DeleteBlog(int blogId)
        {
            return _db.SaveData(storedProcedure: "dbo.spBlog_Delete", new { blogId });
        }
    }
}
