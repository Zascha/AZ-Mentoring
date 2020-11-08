using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VEmployeeDepartmentHistoryMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VEmployeeDepartmentHistory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VEmployeeDepartmentHistory> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vEmployeeDepartmentHistory", "HumanResources");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

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

            builder.Property(t => t.Shift)
                .IsRequired()
                .HasColumnName("Shift")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Department)
                .IsRequired()
                .HasColumnName("Department")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.GroupName)
                .IsRequired()
                .HasColumnName("GroupName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("date");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("date");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "HumanResources";
            public const string Name = "vEmployeeDepartmentHistory";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string Title = "Title";
            public const string FirstName = "FirstName";
            public const string MiddleName = "MiddleName";
            public const string LastName = "LastName";
            public const string Suffix = "Suffix";
            public const string Shift = "Shift";
            public const string Department = "Department";
            public const string GroupName = "GroupName";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
        }
        #endregion
    }
}
