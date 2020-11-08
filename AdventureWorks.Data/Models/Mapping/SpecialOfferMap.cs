using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class SpecialOfferMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.SpecialOffer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.SpecialOffer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SpecialOffer", "Sales");

            // key
            builder.HasKey(t => t.SpecialOfferID);

            // properties
            builder.Property(t => t.SpecialOfferID)
                .IsRequired()
                .HasColumnName("SpecialOfferID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.DiscountPct)
                .IsRequired()
                .HasColumnName("DiscountPct")
                .HasColumnType("smallmoney")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Category)
                .IsRequired()
                .HasColumnName("Category")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .IsRequired()
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.MinQty)
                .IsRequired()
                .HasColumnName("MinQty")
                .HasColumnType("int");

            builder.Property(t => t.MaxQty)
                .HasColumnName("MaxQty")
                .HasColumnType("int");

            builder.Property(t => t.Rowguid)
                .IsRequired()
                .HasColumnName("rowguid")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newid())");

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
            public const string Name = "SpecialOffer";
        }

        public struct Columns
        {
            public const string SpecialOfferID = "SpecialOfferID";
            public const string Description = "Description";
            public const string DiscountPct = "DiscountPct";
            public const string Type = "Type";
            public const string Category = "Category";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string MinQty = "MinQty";
            public const string MaxQty = "MaxQty";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
