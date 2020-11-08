using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VIndividualCustomerMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VIndividualCustomer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VIndividualCustomer> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vIndividualCustomer", "Sales");

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

            builder.Property(t => t.Demographics)
                .HasColumnName("Demographics")
                .HasColumnType("xml");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "vIndividualCustomer";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string Title = "Title";
            public const string FirstName = "FirstName";
            public const string MiddleName = "MiddleName";
            public const string LastName = "LastName";
            public const string Suffix = "Suffix";
            public const string PhoneNumber = "PhoneNumber";
            public const string PhoneNumberType = "PhoneNumberType";
            public const string EmailAddress = "EmailAddress";
            public const string EmailPromotion = "EmailPromotion";
            public const string AddressType = "AddressType";
            public const string AddressLine1 = "AddressLine1";
            public const string AddressLine2 = "AddressLine2";
            public const string City = "City";
            public const string StateProvinceName = "StateProvinceName";
            public const string PostalCode = "PostalCode";
            public const string CountryRegionName = "CountryRegionName";
            public const string Demographics = "Demographics";
        }
        #endregion
    }
}
