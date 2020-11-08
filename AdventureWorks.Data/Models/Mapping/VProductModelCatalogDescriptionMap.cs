using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class VProductModelCatalogDescriptionMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.VProductModelCatalogDescription>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.VProductModelCatalogDescription> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vProductModelCatalogDescription", "Production");

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

            builder.Property(t => t.Summary)
                .HasColumnName("Summary")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Manufacturer)
                .HasColumnName("Manufacturer")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Copyright)
                .HasColumnName("Copyright")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ProductURL)
                .HasColumnName("ProductURL")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.WarrantyPeriod)
                .HasColumnName("WarrantyPeriod")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.WarrantyDescription)
                .HasColumnName("WarrantyDescription")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.NoOfYears)
                .HasColumnName("NoOfYears")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.MaintenanceDescription)
                .HasColumnName("MaintenanceDescription")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.Wheel)
                .HasColumnName("Wheel")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.Saddle)
                .HasColumnName("Saddle")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.Pedal)
                .HasColumnName("Pedal")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.BikeFrame)
                .HasColumnName("BikeFrame")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Crankset)
                .HasColumnName("Crankset")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.PictureAngle)
                .HasColumnName("PictureAngle")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.PictureSize)
                .HasColumnName("PictureSize")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.ProductPhotoID)
                .HasColumnName("ProductPhotoID")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.Material)
                .HasColumnName("Material")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.Color)
                .HasColumnName("Color")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.ProductLine)
                .HasColumnName("ProductLine")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.Style)
                .HasColumnName("Style")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.RiderExperience)
                .HasColumnName("RiderExperience")
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
            public const string Name = "vProductModelCatalogDescription";
        }

        public struct Columns
        {
            public const string ProductModelID = "ProductModelID";
            public const string Name = "Name";
            public const string Summary = "Summary";
            public const string Manufacturer = "Manufacturer";
            public const string Copyright = "Copyright";
            public const string ProductURL = "ProductURL";
            public const string WarrantyPeriod = "WarrantyPeriod";
            public const string WarrantyDescription = "WarrantyDescription";
            public const string NoOfYears = "NoOfYears";
            public const string MaintenanceDescription = "MaintenanceDescription";
            public const string Wheel = "Wheel";
            public const string Saddle = "Saddle";
            public const string Pedal = "Pedal";
            public const string BikeFrame = "BikeFrame";
            public const string Crankset = "Crankset";
            public const string PictureAngle = "PictureAngle";
            public const string PictureSize = "PictureSize";
            public const string ProductPhotoID = "ProductPhotoID";
            public const string Material = "Material";
            public const string Color = "Color";
            public const string ProductLine = "ProductLine";
            public const string Style = "Style";
            public const string RiderExperience = "RiderExperience";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
