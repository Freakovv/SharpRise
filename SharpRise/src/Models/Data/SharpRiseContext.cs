using Microsoft.EntityFrameworkCore;
using SharpRise.src.Models.Entities;

namespace SharpRise.src.Models.Data
{
    public class SharpRiseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public SharpRiseContext(DbContextOptions<SharpRiseContext> options)
            : base(options)
        {
        }
    }
}