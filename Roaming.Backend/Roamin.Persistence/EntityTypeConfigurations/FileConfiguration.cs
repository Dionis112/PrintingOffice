using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Roaming.Persistence.EntityTypeConfigurations
{
    public class FileConfiguration : IEntityTypeConfiguration<Roaming.Domain.File>
    {
        public void Configure(EntityTypeBuilder<Roaming.Domain.File> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.HasOne(e => e.Document).WithMany(e => e.Files);
        }
    }
}
