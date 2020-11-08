using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VJobCandidateEmploymentMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VJobCandidateEmployment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VJobCandidateEmployment> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vJobCandidateEmployment", "HumanResources");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.JobCandidateID)
                .IsRequired()
                .HasColumnName("JobCandidateID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.EmpStartDate)
                .HasColumnName("Emp.StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EmpEndDate)
                .HasColumnName("Emp.EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EmpOrgName)
                .HasColumnName("Emp.OrgName")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.EmpJobTitle)
                .HasColumnName("Emp.JobTitle")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.EmpResponsibility)
                .HasColumnName("Emp.Responsibility")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.EmpFunctionCategory)
                .HasColumnName("Emp.FunctionCategory")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.EmpIndustryCategory)
                .HasColumnName("Emp.IndustryCategory")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.EmpLocCountryRegion)
                .HasColumnName("Emp.Loc.CountryRegion")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.EmpLocState)
                .HasColumnName("Emp.Loc.State")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.EmpLocCity)
                .HasColumnName("Emp.Loc.City")
                .HasColumnType("nvarchar(max)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "HumanResources";
            public const string Name = "vJobCandidateEmployment";
        }

        public struct Columns
        {
            public const string JobCandidateID = "JobCandidateID";
            public const string EmpStartDate = "Emp.StartDate";
            public const string EmpEndDate = "Emp.EndDate";
            public const string EmpOrgName = "Emp.OrgName";
            public const string EmpJobTitle = "Emp.JobTitle";
            public const string EmpResponsibility = "Emp.Responsibility";
            public const string EmpFunctionCategory = "Emp.FunctionCategory";
            public const string EmpIndustryCategory = "Emp.IndustryCategory";
            public const string EmpLocCountryRegion = "Emp.Loc.CountryRegion";
            public const string EmpLocState = "Emp.Loc.State";
            public const string EmpLocCity = "Emp.Loc.City";
        }
        #endregion
    }
}
