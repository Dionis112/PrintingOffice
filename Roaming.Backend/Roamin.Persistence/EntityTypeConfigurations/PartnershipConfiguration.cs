using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Roaming.Domain;

namespace Roaming.Persistence.EntityTypeConfigurations
{
    public class PartnershipConfiguration : IEntityTypeConfiguration<Partnership>
    {
        public void Configure(EntityTypeBuilder<Partnership> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.HasOne(e => e.FirstCounterparty).WithMany(e => e.FirstPartnerships);
            builder.HasOne(e => e.SecondCounterparty).WithMany(e => e.SecondPartnerships);
        }
    }
}
