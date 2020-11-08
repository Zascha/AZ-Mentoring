using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VStoreWithDemographicsMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VStoreWithDemographics>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VStoreWithDemographics> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vStoreWithDemographics", "Sales");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.AnnualSales)
                .HasColumnName("AnnualSales")
                .HasColumnType("money");

            builder.Property(t => t.AnnualRevenue)
                .HasColumnName("AnnualRevenue")
                .HasColumnType("money");

            builder.Property(t => t.BankName)
                .HasColumnName("BankName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.BusinessType)
                .HasColumnName("BusinessType")
                .HasColumnType("nvarchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.YearOpened)
                .HasColumnName("YearOpened")
                .HasColumnType("int");

            builder.Property(t => t.Specialty)
                .HasColumnName("Specialty")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SquareFeet)
                .HasColumnName("SquareFeet")
                .HasColumnType("int");

            builder.Property(t => t.Brands)
                .HasColumnName("Brands")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Internet)
                .HasColumnName("Internet")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.NumberEmployees)
                .HasColumnName("NumberEmployees")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "vStoreWithDemographics";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string Name = "Name";
            public const string AnnualSales = "AnnualSales";
            public const string AnnualRevenue = "AnnualRevenue";
            public const string BankName = "BankName";
            public const string BusinessType = "BusinessType";
            public const string YearOpened = "YearOpened";
            public const string Specialty = "Specialty";
            public const string SquareFeet = "SquareFeet";
            public const string Brands = "Brands";
            public const string Internet = "Internet";
            public const string NumberEmployees = "NumberEmployees";
        }
        #endregion
    }
}
