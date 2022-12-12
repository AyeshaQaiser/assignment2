using Microsoft.EntityFrameworkCore;

namespace assignment2.Models
{
    public class WebDbContext:DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base (options)
        {

        }
        public DbSet<DataModel> DataModels { get; set; }
    }
}
