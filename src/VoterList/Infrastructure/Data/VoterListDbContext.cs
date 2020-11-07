using System.Reflection;
using Microsoft.EntityFrameworkCore;
using VoterList.Core.Jurisdiction;

namespace VoterList.Infrastructure.Data
{
    public class VoterListDbContext : DbContext
    {
        public DbSet<State> States { get; set; }
        public DbSet<District> Districts { get; set; }
        public VoterListDbContext(DbContextOptions<VoterListDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
