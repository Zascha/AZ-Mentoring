using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class DepartmentMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.Department> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Department", "HumanResources");

            // key
            builder.HasKey(t => t.DepartmentID);

            // properties
            builder.Property(t => t.DepartmentID)
                .IsRequired()
                .HasColumnName("DepartmentID")
                .HasColumnType("smallint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.GroupName)
                .IsRequired()
                .HasColumnName("GroupName")
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
            public const string Schema = "HumanResources";
            public const string Name = "Department";
        }

        public struct Columns
        {
            public const string DepartmentID = "DepartmentID";
            public const string Name = "Name";
            public const string GroupName = "GroupName";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
