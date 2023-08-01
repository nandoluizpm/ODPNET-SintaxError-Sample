using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ODP.SintaxError.Sample.Entities;

namespace ODP.SintaxError.Sample.Contexts.Maps;

public class PartMap : IEntityTypeConfiguration<Part>
{
    public void Configure(EntityTypeBuilder<Part> builder)
    {
        builder.ToTable("TBLPART");
        builder.HasKey(x => new { x.Code, x.Number});

        builder.Property(e => e.Code)
            .HasColumnName("PROCESSID")
            .HasMaxLength(13)
            .IsUnicode(false)
            .IsFixedLength();
            
        builder.Property(e => e.Number)
            .HasColumnName("PARTNUMBER")
            .HasColumnType("DECIMAL(10, 5)");
    }
}