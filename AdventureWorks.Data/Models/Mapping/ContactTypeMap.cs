using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class ContactTypeMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.ContactType>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.ContactType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ContactType", "Person");

            // key
            builder.HasKey(t => t.ContactTypeID);

            // properties
            builder.Property(t => t.ContactTypeID)
                .IsRequired()
                .HasColumnName("ContactTypeID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Person";
            public const string Name = "ContactType";
        }

        public struct Columns
        {
            public const string ContactTypeID = "ContactTypeID";
            public const string Name = "Name";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
