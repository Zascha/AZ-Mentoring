using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VendorMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.Vendor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.Vendor> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Vendor", "Purchasing");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.AccountNumber)
                .IsRequired()
                .HasColumnName("AccountNumber")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CreditRating)
                .IsRequired()
                .HasColumnName("CreditRating")
                .HasColumnType("tinyint");

            builder.Property(t => t.PreferredVendorStatus)
                .IsRequired()
                .HasColumnName("PreferredVendorStatus")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.ActiveFlag)
                .IsRequired()
                .HasColumnName("ActiveFlag")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.PurchasingWebServiceURL)
                .HasColumnName("PurchasingWebServiceURL")
                .HasColumnType("nvarchar(1024)")
                .HasMaxLength(1024);

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.BusinessEntity)
                .WithOne(t => t.Vendor)
                .HasForeignKey<AdventureWorks.Data.Models.Vendor>(d => d.BusinessEntityID)
                .HasConstraintName("FK_Vendor_BusinessEntity_BusinessEntityID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Purchasing";
            public const string Name = "Vendor";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string AccountNumber = "AccountNumber";
            public const string Name = "Name";
            public const string CreditRating = "CreditRating";
            public const string PreferredVendorStatus = "PreferredVendorStatus";
            public const string ActiveFlag = "ActiveFlag";
            public const string PurchasingWebServiceURL = "PurchasingWebServiceURL";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
