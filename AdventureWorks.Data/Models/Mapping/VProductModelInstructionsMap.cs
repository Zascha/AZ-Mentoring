using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VProductModelInstructionsMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VProductModelInstructions>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VProductModelInstructions> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vProductModelInstructions", "Production");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.ProductModelID)
                .IsRequired()
                .HasColumnName("ProductModelID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Instructions)
                .HasColumnName("Instructions")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.LocationID)
                .HasColumnName("LocationID")
                .HasColumnType("int");

            builder.Property(t => t.SetupHours)
                .HasColumnName("SetupHours")
                .HasColumnType("decimal(9,4)");

            builder.Property(t => t.MachineHours)
                .HasColumnName("MachineHours")
                .HasColumnType("decimal(9,4)");

            builder.Property(t => t.LaborHours)
                .HasColumnName("LaborHours")
                .HasColumnType("decimal(9,4)");

            builder.Property(t => t.LotSize)
                .HasColumnName("LotSize")
                .HasColumnType("int");

            builder.Property(t => t.Step)
                .HasColumnName("Step")
                .HasColumnType("nvarchar(1024)")
                .HasMaxLength(1024);

            builder.Property(t => t.Rowguid)
                .IsRequired()
                .HasColumnName("rowguid")
                .HasColumnType("uniqueidentifier");

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
            public const string Schema = "Production";
            public const string Name = "vProductModelInstructions";
        }

        public struct Columns
        {
            public const string ProductModelID = "ProductModelID";
            public const string Name = "Name";
            public const string Instructions = "Instructions";
            public const string LocationID = "LocationID";
            public const string SetupHours = "SetupHours";
            public const string MachineHours = "MachineHours";
            public const string LaborHours = "LaborHours";
            public const string LotSize = "LotSize";
            public const string Step = "Step";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
