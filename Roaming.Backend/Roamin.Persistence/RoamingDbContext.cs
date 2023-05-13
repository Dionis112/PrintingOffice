using Microsoft.EntityFrameworkCore;
using Roaming.Application.Interfaces;
using Roaming.Domain;
using Roaming.Persistence.EntityTypeConfigurations;

namespace Roamin.Persistence
{
    public class RoamingDbContext : DbContext, IRoamingDbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Counterparty> Counterparties { get; set; }
        public DbSet<Partnership> Partnerships { get; set; }

        public RoamingDbContext(DbContextOptions<RoamingDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CounterpartyConfiguration());
            builder.ApplyConfiguration(new PartnershipConfiguration());
            builder.ApplyConfiguration(new DocumentConfiguration());
            builder.ApplyConfiguration(new FileConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
