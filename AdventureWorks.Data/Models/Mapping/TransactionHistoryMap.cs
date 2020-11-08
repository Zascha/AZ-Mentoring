using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class TransactionHistoryMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.TransactionHistory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.TransactionHistory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("TransactionHistory", "Production");

            // key
            builder.HasKey(t => t.TransactionID);

            // properties
            builder.Property(t => t.TransactionID)
                .IsRequired()
                .HasColumnName("TransactionID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int");

            builder.Property(t => t.ReferenceOrderID)
                .IsRequired()
                .HasColumnName("ReferenceOrderID")
                .HasColumnType("int");

            builder.Property(t => t.ReferenceOrderLineID)
                .IsRequired()
                .HasColumnName("ReferenceOrderLineID")
                .HasColumnType("int");

            builder.Property(t => t.TransactionDate)
                .IsRequired()
                .HasColumnName("TransactionDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.TransactionType)
                .IsRequired()
                .HasColumnName("TransactionType")
                .HasColumnType("nchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("Quantity")
                .HasColumnType("int");

            builder.Property(t => t.ActualCost)
                .IsRequired()
                .HasColumnName("ActualCost")
                .HasColumnType("money");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.TransactionHistories)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_TransactionHistory_Product_ProductID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Production";
            public const string Name = "TransactionHistory";
        }

        public struct Columns
        {
            public const string TransactionID = "TransactionID";
            public const string ProductID = "ProductID";
            public const string ReferenceOrderID = "ReferenceOrderID";
            public const string ReferenceOrderLineID = "ReferenceOrderLineID";
            public const string TransactionDate = "TransactionDate";
            public const string TransactionType = "TransactionType";
            public const string Quantity = "Quantity";
            public const string ActualCost = "ActualCost";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
