using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class ProductReviewMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.ProductReview>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.ProductReview> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ProductReview", "Production");

            // key
            builder.HasKey(t => t.ProductReviewID);

            // properties
            builder.Property(t => t.ProductReviewID)
                .IsRequired()
                .HasColumnName("ProductReviewID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int");

            builder.Property(t => t.ReviewerName)
                .IsRequired()
                .HasColumnName("ReviewerName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ReviewDate)
                .IsRequired()
                .HasColumnName("ReviewDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.EmailAddress)
                .IsRequired()
                .HasColumnName("EmailAddress")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Rating)
                .IsRequired()
                .HasColumnName("Rating")
                .HasColumnType("int");

            builder.Property(t => t.Comments)
                .HasColumnName("Comments")
                .HasColumnType("nvarchar(3850)")
                .HasMaxLength(3850);

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductReviews)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ProductReview_Product_ProductID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Production";
            public const string Name = "ProductReview";
        }

        public struct Columns
        {
            public const string ProductReviewID = "ProductReviewID";
            public const string ProductID = "ProductID";
            public const string ReviewerName = "ReviewerName";
            public const string ReviewDate = "ReviewDate";
            public const string EmailAddress = "EmailAddress";
            public const string Rating = "Rating";
            public const string Comments = "Comments";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
