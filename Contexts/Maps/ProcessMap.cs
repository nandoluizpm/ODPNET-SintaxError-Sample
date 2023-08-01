using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ODP.SintaxError.Sample.Entities;

namespace ODP.SintaxError.Sample.Contexts.Maps;

public class ProcessMap : IEntityTypeConfiguration<Process>
{
    public void Configure(EntityTypeBuilder<Process> builder)
    {
        builder.ToTable("TBLPROCESS");
        builder.HasKey(k => k.Id);

        builder.Property(e => e.Id)
            .HasColumnName("PROCESSID")
            .HasMaxLength(13)
            .IsUnicode(false)
            .IsFixedLength();
        
        builder.HasMany(x => x.Parts)
            .WithOne()
            .HasForeignKey(x => x.Code);
    }
}