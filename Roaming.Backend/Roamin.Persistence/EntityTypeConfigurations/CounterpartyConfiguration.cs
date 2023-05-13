using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Roaming.Domain;

namespace Roaming.Persistence.EntityTypeConfigurations
{
    public class CounterpartyConfiguration : IEntityTypeConfiguration<Counterparty>
    {
        public void Configure(EntityTypeBuilder<Counterparty> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.HasMany(e => e.SenderDocuments).WithOne(e => e.Sender).HasForeignKey(e => e.SenderId);
            builder.HasMany(e => e.RecipientDocuments).WithOne(e => e.Recipient).HasForeignKey(e => e.RecipientId);
            builder.HasMany(e => e.FirstPartnerships).WithOne(e => e.FirstCounterparty).HasForeignKey(e => e.CounterpartyFirstId);
            builder.HasMany(e => e.SecondPartnerships).WithOne(e => e.SecondCounterparty).HasForeignKey(e => e.CounterpartySecondId);
        }
    }
}
