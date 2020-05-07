using CreateDatabaseFromModel_CodeFirstApproach.DataLayer.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace CreateDatabaseFromModel_CodeFirstApproach.DataLayer
{
    public class DeveloperDbContext : DbContext
    {
        public DeveloperDbContext(DbContextOptions
    <DeveloperDbContext> options) : base(options)
        {
        }
        public DbSet<Developer> Developer { get; set; }
        public DbSet<Country> Country { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new DeveloperEntityConfiguration());
        //}
    }
}
