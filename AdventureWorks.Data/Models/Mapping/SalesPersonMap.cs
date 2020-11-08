using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class SalesPersonMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.SalesPerson>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.SalesPerson> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SalesPerson", "Sales");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                .HasColumnType("int");

            builder.Property(t => t.SalesQuota)
                .HasColumnName("SalesQuota")
                .HasColumnType("money");

            builder.Property(t => t.Bonus)
                .IsRequired()
                .HasColumnName("Bonus")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))");

            builder.Property(t => t.CommissionPct)
                .IsRequired()
                .HasColumnName("CommissionPct")
                .HasColumnType("smallmoney")
                .HasDefaultValueSql("((0.00))");

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
            builder.HasOne(t => t.Employee)
                .WithOne(t => t.SalesPerson)
                .HasForeignKey<AdventureWorks.Data.Models.SalesPerson>(d => d.BusinessEntityID)
                .HasConstraintName("FK_SalesPerson_Employee_BusinessEntityID");

            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.SalesPeople)
                .HasForeignKey(d => d.TerritoryID)
                .HasConstraintName("FK_SalesPerson_SalesTerritory_TerritoryID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "SalesPerson";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string TerritoryID = "TerritoryID";
            public const string SalesQuota = "SalesQuota";
            public const string Bonus = "Bonus";
            public const string CommissionPct = "CommissionPct";
            public const string SalesYTD = "SalesYTD";
            public const string SalesLastYear = "SalesLastYear";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
