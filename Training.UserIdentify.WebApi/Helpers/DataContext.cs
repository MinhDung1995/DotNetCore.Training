using Microsoft.EntityFrameworkCore;
using Training.UserIdentify.WebApi.Entities;

namespace Training.UserIdentify.WebApi.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
