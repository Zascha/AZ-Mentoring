using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class ScrapReasonMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.ScrapReason>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.ScrapReason> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ScrapReason", "Production");

            // key
            builder.HasKey(t => t.ScrapReasonID);

            // properties
            builder.Property(t => t.ScrapReasonID)
                .IsRequired()
                .HasColumnName("ScrapReasonID")
                .HasColumnType("smallint")
                .ValueGeneratedOnAdd();

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
            public const string Name = "ScrapReason";
        }

        public struct Columns
        {
            public const string ScrapReasonID = "ScrapReasonID";
            public const string Name = "Name";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
