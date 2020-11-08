using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VStateProvinceCountryRegionMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VStateProvinceCountryRegion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VStateProvinceCountryRegion> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vStateProvinceCountryRegion", "Person");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.StateProvinceID)
                .IsRequired()
                .HasColumnName("StateProvinceID")
                .HasColumnType("int");

            builder.Property(t => t.StateProvinceCode)
                .IsRequired()
                .HasColumnName("StateProvinceCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.IsOnlyStateProvinceFlag)
                .IsRequired()
                .HasColumnName("IsOnlyStateProvinceFlag")
                .HasColumnType("bit");

            builder.Property(t => t.StateProvinceName)
                .IsRequired()
                .HasColumnName("StateProvinceName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.TerritoryID)
                .IsRequired()
                .HasColumnName("TerritoryID")
                .HasColumnType("int");

            builder.Property(t => t.CountryRegionCode)
                .IsRequired()
                .HasColumnName("CountryRegionCode")
                .HasColumnType("nvarchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.CountryRegionName)
                .IsRequired()
                .HasColumnName("CountryRegionName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Person";
            public const string Name = "vStateProvinceCountryRegion";
        }

        public struct Columns
        {
            public const string StateProvinceID = "StateProvinceID";
            public const string StateProvinceCode = "StateProvinceCode";
            public const string IsOnlyStateProvinceFlag = "IsOnlyStateProvinceFlag";
            public const string StateProvinceName = "StateProvinceName";
            public const string TerritoryID = "TerritoryID";
            public const string CountryRegionCode = "CountryRegionCode";
            public const string CountryRegionName = "CountryRegionName";
        }
        #endregion
    }
}
