using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class AWBuildVersionMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.AWBuildVersion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.AWBuildVersion> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("AWBuildVersion", "dbo");

            // key
            builder.HasKey(t => t.SystemInformationID);

            // properties
            builder.Property(t => t.SystemInformationID)
                .IsRequired()
                .HasColumnName("SystemInformationID")
                .HasColumnType("tinyint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DatabaseVersion)
                .IsRequired()
                .HasColumnName("Database Version")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.VersionDate)
                .IsRequired()
                .HasColumnName("VersionDate")
                .HasColumnType("datetime");

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
            public const string Schema = "dbo";
            public const string Name = "AWBuildVersion";
        }

        public struct Columns
        {
            public const string SystemInformationID = "SystemInformationID";
            public const string DatabaseVersion = "Database Version";
            public const string VersionDate = "VersionDate";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
