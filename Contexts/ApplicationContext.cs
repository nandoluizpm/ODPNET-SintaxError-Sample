using Microsoft.EntityFrameworkCore;

namespace ODP.SintaxError.Sample.Contexts
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseOracle("<ConnectionString>", builder =>
                {
                    builder.UseOracleSQLCompatibility("11");
                });
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}