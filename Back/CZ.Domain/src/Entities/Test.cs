using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CZ.Domain.Entities;

public class Test
{
    public int TestId { get; set; }
}

public class TestTypeConfiguration : IEntityTypeConfiguration<Test>
{
    public void Configure(EntityTypeBuilder<Test> builder)
    {
        builder.HasKey(x => x.TestId);
        builder.Property(x => x.TestId).UseIdentityColumn();
    }
}