using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class SalesOrderHeaderMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.SalesOrderHeader>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.SalesOrderHeader> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SalesOrderHeader", "Sales");

            // key
            builder.HasKey(t => t.SalesOrderID);

            // properties
            builder.Property(t => t.SalesOrderID)
                .IsRequired()
                .HasColumnName("SalesOrderID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RevisionNumber)
                .IsRequired()
                .HasColumnName("RevisionNumber")
                .HasColumnType("tinyint");

            builder.Property(t => t.OrderDate)
                .IsRequired()
                .HasColumnName("OrderDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.DueDate)
                .IsRequired()
                .HasColumnName("DueDate")
                .HasColumnType("datetime");

            builder.Property(t => t.ShipDate)
                .HasColumnName("ShipDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.OnlineOrderFlag)
                .IsRequired()
                .HasColumnName("OnlineOrderFlag")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.SalesOrderNumber)
                .IsRequired()
                .HasColumnName("SalesOrderNumber")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25)
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.PurchaseOrderNumber)
                .HasColumnName("PurchaseOrderNumber")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.AccountNumber)
                .HasColumnName("AccountNumber")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.CustomerID)
                .IsRequired()
                .HasColumnName("CustomerID")
                .HasColumnType("int");

            builder.Property(t => t.SalesPersonID)
                .HasColumnName("SalesPersonID")
                .HasColumnType("int");

            builder.Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                .HasColumnType("int");

            builder.Property(t => t.BillToAddressID)
                .IsRequired()
                .HasColumnName("BillToAddressID")
                .HasColumnType("int");

            builder.Property(t => t.ShipToAddressID)
                .IsRequired()
                .HasColumnName("ShipToAddressID")
                .HasColumnType("int");

            builder.Property(t => t.ShipMethodID)
                .IsRequired()
                .HasColumnName("ShipMethodID")
                .HasColumnType("int");

            builder.Property(t => t.CreditCardID)
                .HasColumnName("CreditCardID")
                .HasColumnType("int");

            builder.Property(t => t.CreditCardApprovalCode)
                .HasColumnName("CreditCardApprovalCode")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.CurrencyRateID)
                .HasColumnName("CurrencyRateID")
                .HasColumnType("int");

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

            builder.Property(t => t.Comment)
                .HasColumnName("Comment")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128);

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
            builder.HasOne(t => t.BillToAddress)
                .WithMany(t => t.BillToSalesOrderHeaders)
                .HasForeignKey(d => d.BillToAddressID)
                .HasConstraintName("FK_SalesOrderHeader_Address_BillToAddressID");

            builder.HasOne(t => t.ShipToAddress)
                .WithMany(t => t.ShipToSalesOrderHeaders)
                .HasForeignKey(d => d.ShipToAddressID)
                .HasConstraintName("FK_SalesOrderHeader_Address_ShipToAddressID");

            builder.HasOne(t => t.CreditCard)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.CreditCardID)
                .HasConstraintName("FK_SalesOrderHeader_CreditCard_CreditCardID");

            builder.HasOne(t => t.CurrencyRate)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.CurrencyRateID)
                .HasConstraintName("FK_SalesOrderHeader_CurrencyRate_CurrencyRateID");

            builder.HasOne(t => t.Customer)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.CustomerID)
                .HasConstraintName("FK_SalesOrderHeader_Customer_CustomerID");

            builder.HasOne(t => t.SalesPerson)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.SalesPersonID)
                .HasConstraintName("FK_SalesOrderHeader_SalesPerson_SalesPersonID");

            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.TerritoryID)
                .HasConstraintName("FK_SalesOrderHeader_SalesTerritory_TerritoryID");

            builder.HasOne(t => t.ShipMethod)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.ShipMethodID)
                .HasConstraintName("FK_SalesOrderHeader_ShipMethod_ShipMethodID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "SalesOrderHeader";
        }

        public struct Columns
        {
            public const string SalesOrderID = "SalesOrderID";
            public const string RevisionNumber = "RevisionNumber";
            public const string OrderDate = "OrderDate";
            public const string DueDate = "DueDate";
            public const string ShipDate = "ShipDate";
            public const string Status = "Status";
            public const string OnlineOrderFlag = "OnlineOrderFlag";
            public const string SalesOrderNumber = "SalesOrderNumber";
            public const string PurchaseOrderNumber = "PurchaseOrderNumber";
            public const string AccountNumber = "AccountNumber";
            public const string CustomerID = "CustomerID";
            public const string SalesPersonID = "SalesPersonID";
            public const string TerritoryID = "TerritoryID";
            public const string BillToAddressID = "BillToAddressID";
            public const string ShipToAddressID = "ShipToAddressID";
            public const string ShipMethodID = "ShipMethodID";
            public const string CreditCardID = "CreditCardID";
            public const string CreditCardApprovalCode = "CreditCardApprovalCode";
            public const string CurrencyRateID = "CurrencyRateID";
            public const string SubTotal = "SubTotal";
            public const string TaxAmt = "TaxAmt";
            public const string Freight = "Freight";
            public const string TotalDue = "TotalDue";
            public const string Comment = "Comment";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
