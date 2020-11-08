using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class UnitMeasureMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.UnitMeasure>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.UnitMeasure> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("UnitMeasure", "Production");

            // key
            builder.HasKey(t => t.UnitMeasureCode);

            // properties
            builder.Property(t => t.UnitMeasureCode)
                .IsRequired()
                .HasColumnName("UnitMeasureCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

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
            public const string Name = "UnitMeasure";
        }

        public struct Columns
        {
            public const string UnitMeasureCode = "UnitMeasureCode";
            public const string Name = "Name";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
