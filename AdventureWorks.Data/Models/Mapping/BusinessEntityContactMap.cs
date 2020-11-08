using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class BusinessEntityContactMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.BusinessEntityContact>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.BusinessEntityContact> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("BusinessEntityContact", "Person");

            // key
            builder.HasKey(t => new { t.BusinessEntityID, t.PersonID, t.ContactTypeID });

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.PersonID)
                .IsRequired()
                .HasColumnName("PersonID")
                .HasColumnType("int");

            builder.Property(t => t.ContactTypeID)
                .IsRequired()
                .HasColumnName("ContactTypeID")
                .HasColumnType("int");

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
            builder.HasOne(t => t.BusinessEntity)
                .WithMany(t => t.BusinessEntityContacts)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_BusinessEntityContact_BusinessEntity_BusinessEntityID");

            builder.HasOne(t => t.ContactType)
                .WithMany(t => t.BusinessEntityContacts)
                .HasForeignKey(d => d.ContactTypeID)
                .HasConstraintName("FK_BusinessEntityContact_ContactType_ContactTypeID");

            builder.HasOne(t => t.Person)
                .WithMany(t => t.BusinessEntityContacts)
                .HasForeignKey(d => d.PersonID)
                .HasConstraintName("FK_BusinessEntityContact_Person_PersonID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Person";
            public const string Name = "BusinessEntityContact";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string PersonID = "PersonID";
            public const string ContactTypeID = "ContactTypeID";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
