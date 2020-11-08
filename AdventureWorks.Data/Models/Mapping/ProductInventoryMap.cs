using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class ProductInventoryMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.ProductInventory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.ProductInventory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductInventory", "Production");

            // key
            builder.HasKey(t => new { t.ProductID, t.LocationID });

            // properties
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int");

            builder.Property(t => t.LocationID)
                .IsRequired()
                .HasColumnName("LocationID")
                .HasColumnType("smallint");

            builder.Property(t => t.Shelf)
                .IsRequired()
                .HasColumnName("Shelf")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Bin)
                .IsRequired()
                .HasColumnName("Bin")
                .HasColumnType("tinyint");

            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("Quantity")
                .HasColumnType("smallint");

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
            builder.HasOne(t => t.Location)
                .WithMany(t => t.ProductInventories)
                .HasForeignKey(d => d.LocationID)
                .HasConstraintName("FK_ProductInventory_Location_LocationID");

            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductInventories)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ProductInventory_Product_ProductID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Production";
            public const string Name = "ProductInventory";
        }

        public struct Columns
        {
            public const string ProductID = "ProductID";
            public const string LocationID = "LocationID";
            public const string Shelf = "Shelf";
            public const string Bin = "Bin";
            public const string Quantity = "Quantity";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
