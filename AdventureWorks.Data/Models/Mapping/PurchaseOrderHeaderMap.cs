using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class PurchaseOrderHeaderMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.PurchaseOrderHeader>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.PurchaseOrderHeader> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PurchaseOrderHeader", "Purchasing");

            // key
            builder.HasKey(t => t.PurchaseOrderID);

            // properties
            builder.Property(t => t.PurchaseOrderID)
                .IsRequired()
                .HasColumnName("PurchaseOrderID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RevisionNumber)
                .IsRequired()
                .HasColumnName("RevisionNumber")
                .HasColumnType("tinyint");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.EmployeeID)
                .IsRequired()
                .HasColumnName("EmployeeID")
                .HasColumnType("int");

            builder.Property(t => t.VendorID)
                .IsRequired()
                .HasColumnName("VendorID")
                .HasColumnType("int");

            builder.Property(t => t.ShipMethodID)
                .IsRequired()
                .HasColumnName("ShipMethodID")
                .HasColumnType("int");

            builder.Property(t => t.OrderDate)
                .IsRequired()
                .HasColumnName("OrderDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.ShipDate)
                .HasColumnName("ShipDate")
                .HasColumnType("datetime");

            builder.Property(t => t.SubTotal)
                .IsRequired()
                .HasColumnName("SubTotal")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.TaxAmt)
                .IsRequired()
                .HasColumnName("TaxAmt")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.Freight)
                .IsRequired()
                .HasColumnName("Freight")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.TotalDue)
                .IsRequired()
                .HasColumnName("TotalDue")
                .HasColumnType("money")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.EmployeeID)
                .HasConstraintName("FK_PurchaseOrderHeader_Employee_EmployeeID");

            builder.HasOne(t => t.ShipMethod)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.ShipMethodID)
                .HasConstraintName("FK_PurchaseOrderHeader_ShipMethod_ShipMethodID");

            builder.HasOne(t => t.Vendor)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.VendorID)
                .HasConstraintName("FK_PurchaseOrderHeader_Vendor_VendorID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Purchasing";
            public const string Name = "PurchaseOrderHeader";
        }

        public struct Columns
        {
            public const string PurchaseOrderID = "PurchaseOrderID";
            public const string RevisionNumber = "RevisionNumber";
            public const string Status = "Status";
            public const string EmployeeID = "EmployeeID";
            public const string VendorID = "VendorID";
            public const string ShipMethodID = "ShipMethodID";
            public const string OrderDate = "OrderDate";
            public const string ShipDate = "ShipDate";
            public const string SubTotal = "SubTotal";
            public const string TaxAmt = "TaxAmt";
            public const string Freight = "Freight";
            public const string TotalDue = "TotalDue";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
