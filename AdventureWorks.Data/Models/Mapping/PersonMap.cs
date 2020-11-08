using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class PersonMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.Person>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.Person> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Person", "Person");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.PersonType)
                .IsRequired()
                .HasColumnName("PersonType")
                .HasColumnType("nchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.NameStyle)
                .IsRequired()
                .HasColumnName("NameStyle")
                .HasColumnType("bit");

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

            builder.Property(t => t.EmailPromotion)
                .IsRequired()
                .HasColumnName("EmailPromotion")
                .HasColumnType("int");

            builder.Property(t => t.AdditionalContactInfo)
                .HasColumnName("AdditionalContactInfo")
                .HasColumnType("xml");

            builder.Property(t => t.Demographics)
                .HasColumnName("Demographics")
                .HasColumnType("xml");

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
                .WithOne(t => t.Person)
                .HasForeignKey<AdventureWorks.Data.Models.Person>(d => d.BusinessEntityID)
                .HasConstraintName("FK_Person_BusinessEntity_BusinessEntityID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Person";
            public const string Name = "Person";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string PersonType = "PersonType";
            public const string NameStyle = "NameStyle";
            public const string Title = "Title";
            public const string FirstName = "FirstName";
            public const string MiddleName = "MiddleName";
            public const string LastName = "LastName";
            public const string Suffix = "Suffix";
            public const string EmailPromotion = "EmailPromotion";
            public const string AdditionalContactInfo = "AdditionalContactInfo";
            public const string Demographics = "Demographics";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
