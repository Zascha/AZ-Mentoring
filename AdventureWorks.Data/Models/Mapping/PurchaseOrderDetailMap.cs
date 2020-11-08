using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class PurchaseOrderDetailMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.PurchaseOrderDetail>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.PurchaseOrderDetail> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PurchaseOrderDetail", "Purchasing");

            // key
            builder.HasKey(t => new { t.PurchaseOrderID, t.PurchaseOrderDetailID });

            // properties
            builder.Property(t => t.PurchaseOrderID)
                .IsRequired()
                .HasColumnName("PurchaseOrderID")
                .HasColumnType("int");

            builder.Property(t => t.PurchaseOrderDetailID)
                .IsRequired()
                .HasColumnName("PurchaseOrderDetailID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DueDate)
                .IsRequired()
                .HasColumnName("DueDate")
                .HasColumnType("datetime");

            builder.Property(t => t.OrderQty)
                .IsRequired()
                .HasColumnName("OrderQty")
                .HasColumnType("smallint");

            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int");

            builder.Property(t => t.UnitPrice)
                .IsRequired()
                .HasColumnName("UnitPrice")
                .HasColumnType("money");

            builder.Property(t => t.LineTotal)
                .IsRequired()
                .HasColumnName("LineTotal")
                .HasColumnType("money")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.ReceivedQty)
                .IsRequired()
                .HasColumnName("ReceivedQty")
                .HasColumnType("decimal(8,2)");

            builder.Property(t => t.RejectedQty)
                .IsRequired()
                .HasColumnName("RejectedQty")
                .HasColumnType("decimal(8,2)");

            builder.Property(t => t.StockedQty)
                .IsRequired()
                .HasColumnName("StockedQty")
                .HasColumnType("decimal(9,2)")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_PurchaseOrderDetail_Product_ProductID");

            builder.HasOne(t => t.PurchaseOrderHeader)
                .WithMany(t => t.PurchaseOrderDetails)
                .HasForeignKey(d => d.PurchaseOrderID)
                .HasConstraintName("FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Purchasing";
            public const string Name = "PurchaseOrderDetail";
        }

        public struct Columns
        {
            public const string PurchaseOrderID = "PurchaseOrderID";
            public const string PurchaseOrderDetailID = "PurchaseOrderDetailID";
            public const string DueDate = "DueDate";
            public const string OrderQty = "OrderQty";
            public const string ProductID = "ProductID";
            public const string UnitPrice = "UnitPrice";
            public const string LineTotal = "LineTotal";
            public const string ReceivedQty = "ReceivedQty";
            public const string RejectedQty = "RejectedQty";
            public const string StockedQty = "StockedQty";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
