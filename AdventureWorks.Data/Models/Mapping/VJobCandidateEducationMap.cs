using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VJobCandidateEducationMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VJobCandidateEducation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VJobCandidateEducation> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vJobCandidateEducation", "HumanResources");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.JobCandidateID)
                .IsRequired()
                .HasColumnName("JobCandidateID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.EduLevel)
                .HasColumnName("Edu.Level")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.EduStartDate)
                .HasColumnName("Edu.StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EduEndDate)
                .HasColumnName("Edu.EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EduDegree)
                .HasColumnName("Edu.Degree")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.EduMajor)
                .HasColumnName("Edu.Major")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.EduMinor)
                .HasColumnName("Edu.Minor")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.EduGPA)
                .HasColumnName("Edu.GPA")
                .HasColumnType("nvarchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.EduGPAScale)
                .HasColumnName("Edu.GPAScale")
                .HasColumnType("nvarchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.EduSchool)
                .HasColumnName("Edu.School")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.EduLocCountryRegion)
                .HasColumnName("Edu.Loc.CountryRegion")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.EduLocState)
                .HasColumnName("Edu.Loc.State")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.EduLocCity)
                .HasColumnName("Edu.Loc.City")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "HumanResources";
            public const string Name = "vJobCandidateEducation";
        }

        public struct Columns
        {
            public const string JobCandidateID = "JobCandidateID";
            public const string EduLevel = "Edu.Level";
            public const string EduStartDate = "Edu.StartDate";
            public const string EduEndDate = "Edu.EndDate";
            public const string EduDegree = "Edu.Degree";
            public const string EduMajor = "Edu.Major";
            public const string EduMinor = "Edu.Minor";
            public const string EduGPA = "Edu.GPA";
            public const string EduGPAScale = "Edu.GPAScale";
            public const string EduSchool = "Edu.School";
            public const string EduLocCountryRegion = "Edu.Loc.CountryRegion";
            public const string EduLocState = "Edu.Loc.State";
            public const string EduLocCity = "Edu.Loc.City";
        }
        #endregion
    }
}
