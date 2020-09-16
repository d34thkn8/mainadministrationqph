using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QPH_MAIN.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QPH_MAIN.Infrastructure.Data.Configurations
{
    public class BranchedEnterpriseConfiguration : IEntityTypeConfiguration<Branched_enterprise>
    {
        public void Configure(EntityTypeBuilder<Branched_enterprise> builder)
        {
            builder.ToTable("Branched_Enterprise");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(e => e.Id_enterprise)
                .HasColumnName("id_enterprise");

            builder.Property(e => e.Identification)
                .HasColumnName("identification")
                .HasMaxLength(100);
            builder.Property(e=> e.Direction)
                .HasColumnName("direction")
                .HasMaxLength(300);
            builder.Property(e => e.Latitude)
                .HasColumnName("latitude");

            builder.Property(e => e.Longitude)
                .HasColumnName("latitude");

            

        }
    }
}
