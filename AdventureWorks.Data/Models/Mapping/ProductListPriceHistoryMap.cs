using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class ProductListPriceHistoryMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.ProductListPriceHistory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.ProductListPriceHistory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductListPriceHistory", "Production");

            // key
            builder.HasKey(t => new { t.ProductID, t.StartDate });

            // properties
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int");

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.ListPrice)
                .IsRequired()
                .HasColumnName("ListPrice")
                .HasColumnType("money");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductListPriceHistories)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ProductListPriceHistory_Product_ProductID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Production";
            public const string Name = "ProductListPriceHistory";
        }

        public struct Columns
        {
            public const string ProductID = "ProductID";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string ListPrice = "ListPrice";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
