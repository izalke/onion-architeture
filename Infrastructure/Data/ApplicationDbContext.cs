using Microsoft.EntityFrameworkCore;
using onion_architeture.Core.Entities;
using SklepMotorowy.Core.Entities;

namespace onion_architeture.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Motorcycle> Motorcycles { get; set; }

        public DbSet<ClientAndMotorcycle> ClientMotorcycles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientAndMotorcycle>()
                .HasKey(cm => new { cm.ClientId, cm.MotorcycleId });

            modelBuilder.Entity<ClientAndMotorcycle>()
                .HasOne(cm => cm.Client)
                .WithMany(c => c.ClientAndMotorcycles)
                .HasForeignKey(cm => cm.ClientId);

            modelBuilder.Entity<ClientAndMotorcycle>()
                .HasOne(cm => cm.Motorcycle)
                .WithMany(m => m.ClientAndMotorcycles)
                .HasForeignKey(cm => cm.MotorcycleId);

            modelBuilder.Entity<Insurance>()
              .HasKey(i => i.InsuranceNumber);

            modelBuilder.Entity<Insurance>()
                .HasOne(i => i.Motorcycle)
                .WithMany(m => m.Insurances)
                .HasForeignKey(i => i.MotorcycleId);
        }
    }
}
