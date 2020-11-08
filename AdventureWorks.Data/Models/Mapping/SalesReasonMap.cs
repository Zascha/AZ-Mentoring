using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class SalesReasonMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.SalesReason>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.SalesReason> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SalesReason", "Sales");

            // key
            builder.HasKey(t => t.SalesReasonID);

            // properties
            builder.Property(t => t.SalesReasonID)
                .IsRequired()
                .HasColumnName("SalesReasonID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ReasonType)
                .IsRequired()
                .HasColumnName("ReasonType")
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
            public const string Schema = "Sales";
            public const string Name = "SalesReason";
        }

        public struct Columns
        {
            public const string SalesReasonID = "SalesReasonID";
            public const string Name = "Name";
            public const string ReasonType = "ReasonType";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
