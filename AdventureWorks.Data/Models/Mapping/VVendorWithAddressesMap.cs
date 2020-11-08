using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VVendorWithAddressesMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VVendorWithAddresses>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VVendorWithAddresses> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vVendorWithAddresses", "Purchasing");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.AddressType)
                .IsRequired()
                .HasColumnName("AddressType")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.AddressLine1)
                .IsRequired()
                .HasColumnName("AddressLine1")
                .HasColumnType("nvarchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.AddressLine2)
                .HasColumnName("AddressLine2")
                .HasColumnType("nvarchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.City)
                .IsRequired()
                .HasColumnName("City")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.StateProvinceName)
                .IsRequired()
                .HasColumnName("StateProvinceName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PostalCode)
                .IsRequired()
                .HasColumnName("PostalCode")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.CountryRegionName)
                .IsRequired()
                .HasColumnName("CountryRegionName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Purchasing";
            public const string Name = "vVendorWithAddresses";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string Name = "Name";
            public const string AddressType = "AddressType";
            public const string AddressLine1 = "AddressLine1";
            public const string AddressLine2 = "AddressLine2";
            public const string City = "City";
            public const string StateProvinceName = "StateProvinceName";
            public const string PostalCode = "PostalCode";
            public const string CountryRegionName = "CountryRegionName";
        }
        #endregion
    }
}
