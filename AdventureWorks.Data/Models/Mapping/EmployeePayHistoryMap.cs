using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class EmployeePayHistoryMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.EmployeePayHistory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.EmployeePayHistory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("EmployeePayHistory", "HumanResources");

            // key
            builder.HasKey(t => new { t.BusinessEntityID, t.RateChangeDate });

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.RateChangeDate)
                .IsRequired()
                .HasColumnName("RateChangeDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Rate)
                .IsRequired()
                .HasColumnName("Rate")
                .HasColumnType("money");

            builder.Property(t => t.PayFrequency)
                .IsRequired()
                .HasColumnName("PayFrequency")
                .HasColumnType("tinyint");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.EmployeePayHistories)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_EmployeePayHistory_Employee_BusinessEntityID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "HumanResources";
            public const string Name = "EmployeePayHistory";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string RateChangeDate = "RateChangeDate";
            public const string Rate = "Rate";
            public const string PayFrequency = "PayFrequency";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
