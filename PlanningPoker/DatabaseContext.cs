using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL;

using Microsoft.Extensions.Configuration;
using PlanningPoker.Models;

namespace PlanningPoker
{
    public class DatabaseContext : DbContext
    {
        private readonly DatabaseConfig _config;

        public DatabaseContext(DatabaseConfig config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_config.ConnectionString);
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
