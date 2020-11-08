using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class SpecialOfferProductMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.SpecialOfferProduct>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.SpecialOfferProduct> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SpecialOfferProduct", "Sales");

            // key
            builder.HasKey(t => new { t.SpecialOfferID, t.ProductID });

            // properties
            builder.Property(t => t.SpecialOfferID)
                .IsRequired()
                .HasColumnName("SpecialOfferID")
                .HasColumnType("int");

            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
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
            builder.HasOne(t => t.Product)
                .WithMany(t => t.SpecialOfferProducts)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_SpecialOfferProduct_Product_ProductID");

            builder.HasOne(t => t.SpecialOffer)
                .WithMany(t => t.SpecialOfferProducts)
                .HasForeignKey(d => d.SpecialOfferID)
                .HasConstraintName("FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "SpecialOfferProduct";
        }

        public struct Columns
        {
            public const string SpecialOfferID = "SpecialOfferID";
            public const string ProductID = "ProductID";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
