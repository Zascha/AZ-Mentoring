using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class ProductCostHistoryMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.ProductCostHistory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.ProductCostHistory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductCostHistory", "Production");

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

            builder.Property(t => t.StandardCost)
                .IsRequired()
                .HasColumnName("StandardCost")
                .HasColumnType("money");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductCostHistories)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ProductCostHistory_Product_ProductID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Production";
            public const string Name = "ProductCostHistory";
        }

        public struct Columns
        {
            public const string ProductID = "ProductID";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string StandardCost = "StandardCost";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
