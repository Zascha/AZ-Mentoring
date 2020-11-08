using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class ProductModelMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.ProductModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.ProductModel> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductModel", "Production");

            // key
            builder.HasKey(t => t.ProductModelID);

            // properties
            builder.Property(t => t.ProductModelID)
                .IsRequired()
                .HasColumnName("ProductModelID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CatalogDescription)
                .HasColumnName("CatalogDescription")
                .HasColumnType("xml");

            builder.Property(t => t.Instructions)
                .HasColumnName("Instructions")
                .HasColumnType("xml");

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
            public const string Name = "ProductModel";
        }

        public struct Columns
        {
            public const string ProductModelID = "ProductModelID";
            public const string Name = "Name";
            public const string CatalogDescription = "CatalogDescription";
            public const string Instructions = "Instructions";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
