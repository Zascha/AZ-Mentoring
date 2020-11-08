using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class IllustrationMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.Illustration>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.Illustration> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Illustration", "Production");

            // key
            builder.HasKey(t => t.IllustrationID);

            // properties
            builder.Property(t => t.IllustrationID)
                .IsRequired()
                .HasColumnName("IllustrationID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Diagram)
                .HasColumnName("Diagram")
                .HasColumnType("xml");

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
            public const string Schema = "Production";
            public const string Name = "Illustration";
        }

        public struct Columns
        {
            public const string IllustrationID = "IllustrationID";
            public const string Diagram = "Diagram";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
