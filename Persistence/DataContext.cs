
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

    //properties within activities are going be based on the Activity table
        public DbSet<Activity> Activities { get; set; }
    }
}