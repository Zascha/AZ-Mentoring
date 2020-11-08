using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VPersonDemographicsMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VPersonDemographics>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VPersonDemographics> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vPersonDemographics", "Sales");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.TotalPurchaseYTD)
                .HasColumnName("TotalPurchaseYTD")
                .HasColumnType("money");

            builder.Property(t => t.DateFirstPurchase)
                .HasColumnName("DateFirstPurchase")
                .HasColumnType("datetime");

            builder.Property(t => t.BirthDate)
                .HasColumnName("BirthDate")
                .HasColumnType("datetime");

            builder.Property(t => t.MaritalStatus)
                .HasColumnName("MaritalStatus")
                .HasColumnType("nvarchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.YearlyIncome)
                .HasColumnName("YearlyIncome")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Gender)
                .HasColumnName("Gender")
                .HasColumnType("nvarchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.TotalChildren)
                .HasColumnName("TotalChildren")
                .HasColumnType("int");

            builder.Property(t => t.NumberChildrenAtHome)
                .HasColumnName("NumberChildrenAtHome")
                .HasColumnType("int");

            builder.Property(t => t.Education)
                .HasColumnName("Education")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Occupation)
                .HasColumnName("Occupation")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.HomeOwnerFlag)
                .HasColumnName("HomeOwnerFlag")
                .HasColumnType("bit");

            builder.Property(t => t.NumberCarsOwned)
                .HasColumnName("NumberCarsOwned")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "vPersonDemographics";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string TotalPurchaseYTD = "TotalPurchaseYTD";
            public const string DateFirstPurchase = "DateFirstPurchase";
            public const string BirthDate = "BirthDate";
            public const string MaritalStatus = "MaritalStatus";
            public const string YearlyIncome = "YearlyIncome";
            public const string Gender = "Gender";
            public const string TotalChildren = "TotalChildren";
            public const string NumberChildrenAtHome = "NumberChildrenAtHome";
            public const string Education = "Education";
            public const string Occupation = "Occupation";
            public const string HomeOwnerFlag = "HomeOwnerFlag";
            public const string NumberCarsOwned = "NumberCarsOwned";
        }
        #endregion
    }
}
