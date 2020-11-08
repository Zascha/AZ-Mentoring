using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class CustomerMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.Customer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Customer", "Sales");

            // key
            builder.HasKey(t => t.CustomerID);

            // properties
            builder.Property(t => t.CustomerID)
                .IsRequired()
                .HasColumnName("CustomerID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.PersonID)
                .HasColumnName("PersonID")
                .HasColumnType("int");

            builder.Property(t => t.StoreID)
                .HasColumnName("StoreID")
                .HasColumnType("int");

            builder.Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                .HasColumnType("int");

            builder.Property(t => t.AccountNumber)
                .IsRequired()
                .HasColumnName("AccountNumber")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .ValueGeneratedOnAddOrUpdate();

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
            builder.HasOne(t => t.Person)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.PersonID)
                .HasConstraintName("FK_Customer_Person_PersonID");

            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.TerritoryID)
                .HasConstraintName("FK_Customer_SalesTerritory_TerritoryID");

            builder.HasOne(t => t.Store)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.StoreID)
                .HasConstraintName("FK_Customer_Store_StoreID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Sales";
            public const string Name = "Customer";
        }

        public struct Columns
        {
            public const string CustomerID = "CustomerID";
            public const string PersonID = "PersonID";
            public const string StoreID = "StoreID";
            public const string TerritoryID = "TerritoryID";
            public const string AccountNumber = "AccountNumber";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
