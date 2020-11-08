using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VSalesPersonSalesByFiscalYearsMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VSalesPersonSalesByFiscalYears>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VSalesPersonSalesByFiscalYears> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vSalesPersonSalesByFiscalYears", "Sales");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.SalesPersonID)
                .HasColumnName("SalesPersonID")
                .HasColumnType("int");

            builder.Property(t => t.FullName)
                .HasColumnName("FullName")
                .HasColumnType("nvarchar(152)")
                .HasMaxLength(152);

            builder.Property(t => t.JobTitle)
                .IsRequired()
                .HasColumnName("JobTitle")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SalesTerritory)
                .IsRequired()
                .HasColumnName("SalesTerritory")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Number2002)
                .HasColumnName("2002")
                .HasColumnType("money");

            builder.Property(t => t.Number2003)
                .HasColumnName("2003")
                .HasColumnType("money");

            builder.Property(t => t.Number2004)
                .HasColumnName("2004")
                .HasColumnType("money");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "vSalesPersonSalesByFiscalYears";
        }

        public struct Columns
        {
            public const string SalesPersonID = "SalesPersonID";
            public const string FullName = "FullName";
            public const string JobTitle = "JobTitle";
            public const string SalesTerritory = "SalesTerritory";
            public const string Number2002 = "2002";
            public const string Number2003 = "2003";
            public const string Number2004 = "2004";
        }
        #endregion
    }
}
