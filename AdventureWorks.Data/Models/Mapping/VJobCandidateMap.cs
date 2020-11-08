using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VJobCandidateMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VJobCandidate>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VJobCandidate> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vJobCandidate", "HumanResources");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.JobCandidateID)
                .IsRequired()
                .HasColumnName("JobCandidateID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.BusinessEntityID)
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.NamePrefix)
                .HasColumnName("Name.Prefix")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.NameFirst)
                .HasColumnName("Name.First")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.NameMiddle)
                .HasColumnName("Name.Middle")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.NameLast)
                .HasColumnName("Name.Last")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.NameSuffix)
                .HasColumnName("Name.Suffix")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Skills)
                .HasColumnName("Skills")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.AddrType)
                .HasColumnName("Addr.Type")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.AddrLocCountryRegion)
                .HasColumnName("Addr.Loc.CountryRegion")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.AddrLocState)
                .HasColumnName("Addr.Loc.State")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.AddrLocCity)
                .HasColumnName("Addr.Loc.City")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.AddrPostalCode)
                .HasColumnName("Addr.PostalCode")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.EMail)
                .HasColumnName("EMail")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.WebSite)
                .HasColumnName("WebSite")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "HumanResources";
            public const string Name = "vJobCandidate";
        }

        public struct Columns
        {
            public const string JobCandidateID = "JobCandidateID";
            public const string BusinessEntityID = "BusinessEntityID";
            public const string NamePrefix = "Name.Prefix";
            public const string NameFirst = "Name.First";
            public const string NameMiddle = "Name.Middle";
            public const string NameLast = "Name.Last";
            public const string NameSuffix = "Name.Suffix";
            public const string Skills = "Skills";
            public const string AddrType = "Addr.Type";
            public const string AddrLocCountryRegion = "Addr.Loc.CountryRegion";
            public const string AddrLocState = "Addr.Loc.State";
            public const string AddrLocCity = "Addr.Loc.City";
            public const string AddrPostalCode = "Addr.PostalCode";
            public const string EMail = "EMail";
            public const string WebSite = "WebSite";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
