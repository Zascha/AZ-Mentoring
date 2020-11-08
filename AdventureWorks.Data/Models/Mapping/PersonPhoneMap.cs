using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class PersonPhoneMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.PersonPhone>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.PersonPhone> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PersonPhone", "Person");

            // key
            builder.HasKey(t => new { t.BusinessEntityID, t.PhoneNumber, t.PhoneNumberTypeID });

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.PhoneNumber)
                .IsRequired()
                .HasColumnName("PhoneNumber")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.PhoneNumberTypeID)
                .IsRequired()
                .HasColumnName("PhoneNumberTypeID")
                .HasColumnType("int");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.Person)
                .WithMany(t => t.PersonPhones)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_PersonPhone_Person_BusinessEntityID");

            builder.HasOne(t => t.PhoneNumberType)
                .WithMany(t => t.PersonPhones)
                .HasForeignKey(d => d.PhoneNumberTypeID)
                .HasConstraintName("FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Person";
            public const string Name = "PersonPhone";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string PhoneNumber = "PhoneNumber";
            public const string PhoneNumberTypeID = "PhoneNumberTypeID";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
