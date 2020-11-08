using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class EmployeeMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.Employee> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Employee", "HumanResources");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.NationalIDNumber)
                .IsRequired()
                .HasColumnName("NationalIDNumber")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.LoginID)
                .IsRequired()
                .HasColumnName("LoginID")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.OrganizationLevel)
                .HasColumnName("OrganizationLevel")
                .HasColumnType("smallint")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.JobTitle)
                .IsRequired()
                .HasColumnName("JobTitle")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.BirthDate)
                .IsRequired()
                .HasColumnName("BirthDate")
                .HasColumnType("date");

            builder.Property(t => t.MaritalStatus)
                .IsRequired()
                .HasColumnName("MaritalStatus")
                .HasColumnType("nchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.Gender)
                .IsRequired()
                .HasColumnName("Gender")
                .HasColumnType("nchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.HireDate)
                .IsRequired()
                .HasColumnName("HireDate")
                .HasColumnType("date");

            builder.Property(t => t.SalariedFlag)
                .IsRequired()
                .HasColumnName("SalariedFlag")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.VacationHours)
                .IsRequired()
                .HasColumnName("VacationHours")
                .HasColumnType("smallint");

            builder.Property(t => t.SickLeaveHours)
                .IsRequired()
                .HasColumnName("SickLeaveHours")
                .HasColumnType("smallint");

            builder.Property(t => t.CurrentFlag)
                .IsRequired()
                .HasColumnName("CurrentFlag")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

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
                .WithOne(t => t.Employee)
                .HasForeignKey<AdventureWorks.Data.Models.Employee>(d => d.BusinessEntityID)
                .HasConstraintName("FK_Employee_Person_BusinessEntityID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "HumanResources";
            public const string Name = "Employee";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string NationalIDNumber = "NationalIDNumber";
            public const string LoginID = "LoginID";
            public const string OrganizationLevel = "OrganizationLevel";
            public const string JobTitle = "JobTitle";
            public const string BirthDate = "BirthDate";
            public const string MaritalStatus = "MaritalStatus";
            public const string Gender = "Gender";
            public const string HireDate = "HireDate";
            public const string SalariedFlag = "SalariedFlag";
            public const string VacationHours = "VacationHours";
            public const string SickLeaveHours = "SickLeaveHours";
            public const string CurrentFlag = "CurrentFlag";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
