using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class SalesTerritoryMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.SalesTerritory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.SalesTerritory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SalesTerritory", "Sales");

            // key
            builder.HasKey(t => t.TerritoryID);

            // properties
            builder.Property(t => t.TerritoryID)
                .IsRequired()
                .HasColumnName("TerritoryID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CountryRegionCode)
                .IsRequired()
                .HasColumnName("CountryRegionCode")
                .HasColumnType("nvarchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.Group)
                .IsRequired()
                .HasColumnName("Group")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SalesYTD)
                .IsRequired()
                .HasColumnName("SalesYTD")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.SalesLastYear)
                .IsRequired()
                .HasColumnName("SalesLastYear")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.CostYTD)
                .IsRequired()
                .HasColumnName("CostYTD")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.CostLastYear)
                .IsRequired()
                .HasColumnName("CostLastYear")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))");

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
            builder.HasOne(t => t.CountryRegion)
                .WithMany(t => t.SalesTerritories)
                .HasForeignKey(d => d.CountryRegionCode)
                .HasConstraintName("FK_SalesTerritory_CountryRegion_CountryRegionCode");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "SalesTerritory";
        }

        public struct Columns
        {
            public const string TerritoryID = "TerritoryID";
            public const string Name = "Name";
            public const string CountryRegionCode = "CountryRegionCode";
            public const string Group = "Group";
            public const string SalesYTD = "SalesYTD";
            public const string SalesLastYear = "SalesLastYear";
            public const string CostYTD = "CostYTD";
            public const string CostLastYear = "CostLastYear";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
