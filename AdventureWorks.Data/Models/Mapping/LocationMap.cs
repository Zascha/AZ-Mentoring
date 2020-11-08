using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class LocationMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.Location>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.Location> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Location", "Production");

            // key
            builder.HasKey(t => t.LocationID);

            // properties
            builder.Property(t => t.LocationID)
                .IsRequired()
                .HasColumnName("LocationID")
                .HasColumnType("smallint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CostRate)
                .IsRequired()
                .HasColumnName("CostRate")
                .HasColumnType("smallmoney")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.Availability)
                .IsRequired()
                .HasColumnName("Availability")
                .HasColumnType("decimal(8,2)")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Production";
            public const string Name = "Location";
        }

        public struct Columns
        {
            public const string LocationID = "LocationID";
            public const string Name = "Name";
            public const string CostRate = "CostRate";
            public const string Availability = "Availability";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
