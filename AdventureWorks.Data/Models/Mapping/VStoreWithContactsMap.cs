using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VStoreWithContactsMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VStoreWithContacts>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VStoreWithContacts> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vStoreWithContacts", "Sales");

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

            builder.Property(t => t.ContactType)
                .IsRequired()
                .HasColumnName("ContactType")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

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

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "vStoreWithContacts";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string Name = "Name";
            public const string ContactType = "ContactType";
            public const string Title = "Title";
            public const string FirstName = "FirstName";
            public const string MiddleName = "MiddleName";
            public const string LastName = "LastName";
            public const string Suffix = "Suffix";
            public const string PhoneNumber = "PhoneNumber";
            public const string PhoneNumberType = "PhoneNumberType";
            public const string EmailAddress = "EmailAddress";
            public const string EmailPromotion = "EmailPromotion";
        }
        #endregion
    }
}
