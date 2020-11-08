using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VSalesPersonMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VSalesPerson>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VSalesPerson> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vSalesPerson", "Sales");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(8)")
                .HasMaxLength(8);

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.MiddleName)
                .HasColumnName("MiddleName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Suffix)
                .HasColumnName("Suffix")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.JobTitle)
                .IsRequired()
                .HasColumnName("JobTitle")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.PhoneNumberType)
                .HasColumnName("PhoneNumberType")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.EmailAddress)
                .HasColumnName("EmailAddress")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.EmailPromotion)
                .IsRequired()
                .HasColumnName("EmailPromotion")
                .HasColumnType("int");

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

            builder.Property(t => t.TerritoryName)
                .HasColumnName("TerritoryName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.TerritoryGroup)
                .HasColumnName("TerritoryGroup")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SalesQuota)
                .HasColumnName("SalesQuota")
                .HasColumnType("money");

            builder.Property(t => t.SalesYTD)
                .IsRequired()
                .HasColumnName("SalesYTD")
                .HasColumnType("money");

            builder.Property(t => t.SalesLastYear)
                .IsRequired()
                .HasColumnName("SalesLastYear")
                .HasColumnType("money");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "vSalesPerson";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string Title = "Title";
            public const string FirstName = "FirstName";
            public const string MiddleName = "MiddleName";
            public const string LastName = "LastName";
            public const string Suffix = "Suffix";
            public const string JobTitle = "JobTitle";
            public const string PhoneNumber = "PhoneNumber";
            public const string PhoneNumberType = "PhoneNumberType";
            public const string EmailAddress = "EmailAddress";
            public const string EmailPromotion = "EmailPromotion";
            public const string AddressLine1 = "AddressLine1";
            public const string AddressLine2 = "AddressLine2";
            public const string City = "City";
            public const string StateProvinceName = "StateProvinceName";
            public const string PostalCode = "PostalCode";
            public const string CountryRegionName = "CountryRegionName";
            public const string TerritoryName = "TerritoryName";
            public const string TerritoryGroup = "TerritoryGroup";
            public const string SalesQuota = "SalesQuota";
            public const string SalesYTD = "SalesYTD";
            public const string SalesLastYear = "SalesLastYear";
        }
        #endregion
    }
}
