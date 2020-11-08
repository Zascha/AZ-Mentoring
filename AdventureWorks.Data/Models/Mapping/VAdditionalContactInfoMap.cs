using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VAdditionalContactInfoMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VAdditionalContactInfo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VAdditionalContactInfo> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vAdditionalContactInfo", "Person");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

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

            builder.Property(t => t.TelephoneNumber)
                .HasColumnName("TelephoneNumber")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.TelephoneSpecialInstructions)
                .HasColumnName("TelephoneSpecialInstructions")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Street)
                .HasColumnName("Street")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.City)
                .HasColumnName("City")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StateProvince)
                .HasColumnName("StateProvince")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PostalCode)
                .HasColumnName("PostalCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CountryRegion)
                .HasColumnName("CountryRegion")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.HomeAddressSpecialInstructions)
                .HasColumnName("HomeAddressSpecialInstructions")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.EMailAddress)
                .HasColumnName("EMailAddress")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.EMailSpecialInstructions)
                .HasColumnName("EMailSpecialInstructions")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.EMailTelephoneNumber)
                .HasColumnName("EMailTelephoneNumber")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Rowguid)
                .IsRequired()
                .HasColumnName("rowguid")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Person";
            public const string Name = "vAdditionalContactInfo";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string FirstName = "FirstName";
            public const string MiddleName = "MiddleName";
            public const string LastName = "LastName";
            public const string TelephoneNumber = "TelephoneNumber";
            public const string TelephoneSpecialInstructions = "TelephoneSpecialInstructions";
            public const string Street = "Street";
            public const string City = "City";
            public const string StateProvince = "StateProvince";
            public const string PostalCode = "PostalCode";
            public const string CountryRegion = "CountryRegion";
            public const string HomeAddressSpecialInstructions = "HomeAddressSpecialInstructions";
            public const string EMailAddress = "EMailAddress";
            public const string EMailSpecialInstructions = "EMailSpecialInstructions";
            public const string EMailTelephoneNumber = "EMailTelephoneNumber";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
