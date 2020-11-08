using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class ProductDescriptionMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.ProductDescription>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.ProductDescription> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductDescription", "Production");

            // key
            builder.HasKey(t => t.ProductDescriptionID);

            // properties
            builder.Property(t => t.ProductDescriptionID)
                .IsRequired()
                .HasColumnName("ProductDescriptionID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("nvarchar(400)")
                .HasMaxLength(400);

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
            public const string Name = "ProductDescription";
        }

        public struct Columns
        {
            public const string ProductDescriptionID = "ProductDescriptionID";
            public const string Description = "Description";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
