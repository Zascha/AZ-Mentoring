using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class ErrorLogMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.ErrorLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.ErrorLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ErrorLog", "dbo");

            // key
            builder.HasKey(t => t.ErrorLogID);

            // properties
            builder.Property(t => t.ErrorLogID)
                .IsRequired()
                .HasColumnName("ErrorLogID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ErrorTime)
                .IsRequired()
                .HasColumnName("ErrorTime")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(t => t.UserName)
                .IsRequired()
                .HasColumnName("UserName")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.ErrorNumber)
                .IsRequired()
                .HasColumnName("ErrorNumber")
                .HasColumnType("int");

            builder.Property(t => t.ErrorSeverity)
                .HasColumnName("ErrorSeverity")
                .HasColumnType("int");

            builder.Property(t => t.ErrorState)
                .HasColumnName("ErrorState")
                .HasColumnType("int");

            builder.Property(t => t.ErrorProcedure)
                .HasColumnName("ErrorProcedure")
                .HasColumnType("nvarchar(126)")
                .HasMaxLength(126);

            builder.Property(t => t.ErrorLine)
                .HasColumnName("ErrorLine")
                .HasColumnType("int");

            builder.Property(t => t.ErrorMessage)
                .IsRequired()
                .HasColumnName("ErrorMessage")
                .HasColumnType("nvarchar(4000)")
                .HasMaxLength(4000);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "ErrorLog";
        }

        public struct Columns
        {
            public const string ErrorLogID = "ErrorLogID";
            public const string ErrorTime = "ErrorTime";
            public const string UserName = "UserName";
            public const string ErrorNumber = "ErrorNumber";
            public const string ErrorSeverity = "ErrorSeverity";
            public const string ErrorState = "ErrorState";
            public const string ErrorProcedure = "ErrorProcedure";
            public const string ErrorLine = "ErrorLine";
            public const string ErrorMessage = "ErrorMessage";
        }
        #endregion
    }
}
