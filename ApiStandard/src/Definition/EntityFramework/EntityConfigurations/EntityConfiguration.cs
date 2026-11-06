using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.EntityConfigurations;

public class EntityConfiguration : IEntityTypeConfiguration<IEntityBase>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<IEntityBase> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnOrder(0);
    }
}