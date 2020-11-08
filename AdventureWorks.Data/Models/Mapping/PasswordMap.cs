using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class PasswordMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.Password>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.Password> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Password", "Person");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.PasswordHash)
                .IsRequired()
                .HasColumnName("PasswordHash")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.PasswordSalt)
                .IsRequired()
                .HasColumnName("PasswordSalt")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

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
                .WithOne(t => t.Password)
                .HasForeignKey<AdventureWorks.Data.Models.Password>(d => d.BusinessEntityID)
                .HasConstraintName("FK_Password_Person_BusinessEntityID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Person";
            public const string Name = "Password";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string PasswordHash = "PasswordHash";
            public const string PasswordSalt = "PasswordSalt";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
