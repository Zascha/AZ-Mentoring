using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class SalesTerritoryHistoryMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.SalesTerritoryHistory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.SalesTerritoryHistory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SalesTerritoryHistory", "Sales");

            // key
            builder.HasKey(t => new { t.BusinessEntityID, t.TerritoryID, t.StartDate });

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int");

            builder.Property(t => t.TerritoryID)
                .IsRequired()
                .HasColumnName("TerritoryID")
                .HasColumnType("int");

            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

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
            builder.HasOne(t => t.SalesPerson)
                .WithMany(t => t.SalesTerritoryHistories)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID");

            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.SalesTerritoryHistories)
                .HasForeignKey(d => d.TerritoryID)
                .HasConstraintName("FK_SalesTerritoryHistory_SalesTerritory_TerritoryID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "SalesTerritoryHistory";
        }

        public struct Columns
        {
            public const string BusinessEntityID = "BusinessEntityID";
            public const string TerritoryID = "TerritoryID";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
