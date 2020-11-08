using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class DatabaseLogMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.DatabaseLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.DatabaseLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("DatabaseLog", "dbo");

            // key
            builder.HasKey(t => t.DatabaseLogID);

            // properties
            builder.Property(t => t.DatabaseLogID)
                .IsRequired()
                .HasColumnName("DatabaseLogID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.PostTime)
                .IsRequired()
                .HasColumnName("PostTime")
                .HasColumnType("datetime");

            builder.Property(t => t.DatabaseUser)
                .IsRequired()
                .HasColumnName("DatabaseUser")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Event)
                .IsRequired()
                .HasColumnName("Event")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Schema)
                .HasColumnName("Schema")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Object)
                .HasColumnName("Object")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Tsql)
                .IsRequired()
                .HasColumnName("TSQL")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.XmlEvent)
                .IsRequired()
                .HasColumnName("XmlEvent")
                .HasColumnType("xml");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "DatabaseLog";
        }

        public struct Columns
        {
            public const string DatabaseLogID = "DatabaseLogID";
            public const string PostTime = "PostTime";
            public const string DatabaseUser = "DatabaseUser";
            public const string Event = "Event";
            public const string Schema = "Schema";
            public const string Object = "Object";
            public const string Tsql = "TSQL";
            public const string XmlEvent = "XmlEvent";
        }
        #endregion
    }
}
