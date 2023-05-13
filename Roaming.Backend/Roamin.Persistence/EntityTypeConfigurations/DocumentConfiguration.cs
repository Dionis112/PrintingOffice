using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Roaming.Domain;

namespace Roaming.Persistence.EntityTypeConfigurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.HasMany(e => e.Files).WithOne(e => e.Document).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Sender).WithMany(e => e.SenderDocuments);
            builder.HasOne(e => e.Recipient).WithMany(e => e.RecipientDocuments);
        }
    }
}
