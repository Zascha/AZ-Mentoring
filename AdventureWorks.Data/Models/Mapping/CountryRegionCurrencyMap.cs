using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class CountryRegionCurrencyMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.CountryRegionCurrency>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.CountryRegionCurrency> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CountryRegionCurrency", "Sales");

            // key
            builder.HasKey(t => new { t.CountryRegionCode, t.CurrencyCode });

            // properties
            builder.Property(t => t.CountryRegionCode)
                .IsRequired()
                .HasColumnName("CountryRegionCode")
                .HasColumnType("nvarchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.CurrencyCode)
                .IsRequired()
                .HasColumnName("CurrencyCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            // relationships
            builder.HasOne(t => t.CountryRegion)
                .WithMany(t => t.CountryRegionCurrencies)
                .HasForeignKey(d => d.CountryRegionCode)
                .HasConstraintName("FK_CountryRegionCurrency_CountryRegion_CountryRegionCode");

            builder.HasOne(t => t.Currency)
                .WithMany(t => t.CountryRegionCurrencies)
                .HasForeignKey(d => d.CurrencyCode)
                .HasConstraintName("FK_CountryRegionCurrency_Currency_CurrencyCode");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "CountryRegionCurrency";
        }

        public struct Columns
        {
            public const string CountryRegionCode = "CountryRegionCode";
            public const string CurrencyCode = "CurrencyCode";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
