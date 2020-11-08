using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class EmailAddressMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.EmailAddress>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.EmailAddress> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("EmailAddress", "Person");

            // key
            builder.HasKey(t => new { t.BusinessEntityID, t.EmailAddressID });

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.EmailAddressID)
                .IsRequired()
                .HasColumnName("EmailAddressID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.EmailAddressMember)
                .HasColumnName("EmailAddress")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

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
            builder.HasOne(t => t.Person)
                .WithMany(t => t.EmailAddresses)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_EmailAddress_Person_BusinessEntityID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Person";
            public const string Name = "EmailAddress";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string EmailAddressID = "EmailAddressID";
            public const string EmailAddressMember = "EmailAddress";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
