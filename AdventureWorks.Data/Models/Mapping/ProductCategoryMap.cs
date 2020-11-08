using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class ProductCategoryMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.ProductCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.ProductCategory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductCategory", "Production");

            // key
            builder.HasKey(t => t.ProductCategoryID);

            // properties
            builder.Property(t => t.ProductCategoryID)
                .IsRequired()
                .HasColumnName("ProductCategoryID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

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
            public const string Schema = "Production";
            public const string Name = "ProductCategory";
        }

        public struct Columns
        {
            public const string ProductCategoryID = "ProductCategoryID";
            public const string Name = "Name";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
