using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Models.Mapping
{
    public partial class DocumentMap
        : IEntityTypeConfiguration<AdventureWorks.Data.Models.Document>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Data.Models.Document> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Document", "Production");

            // key
            builder.HasKey(x => x.DocumentId);

            // properties
            builder.Property(t => t.DocumentLevel)
                .HasColumnName("DocumentLevel")
                .HasColumnType("smallint")
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Owner)
                .IsRequired()
                .HasColumnName("Owner")
                .HasColumnType("int");

            builder.Property(t => t.FolderFlag)
                .IsRequired()
                .HasColumnName("FolderFlag")
                .HasColumnType("bit");

            builder.Property(t => t.FileName)
                .IsRequired()
                .HasColumnName("FileName")
                .HasColumnType("nvarchar(400)")
                .HasMaxLength(400);

            builder.Property(t => t.FileExtension)
                .IsRequired()
                .HasColumnName("FileExtension")
                .HasColumnType("nvarchar(8)")
                .HasMaxLength(8);

            builder.Property(t => t.Revision)
                .IsRequired()
                .HasColumnName("Revision")
                .HasColumnType("nchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.ChangeNumber)
                .IsRequired()
                .HasColumnName("ChangeNumber")
                .HasColumnType("int");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("tinyint");

            builder.Property(t => t.DocumentSummary)
                .HasColumnName("DocumentSummary")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.DocumentMember)
                .HasColumnName("Document")
                .HasColumnType("varbinary(max)");

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
            builder.HasOne(t => t.OwnerEmployee)
                .WithMany(t => t.OwnerDocuments)
                .HasForeignKey(d => d.Owner)
                .HasConstraintName("FK_Document_Employee_Owner");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "Production";
            public const string Name = "Document";
        }

        public struct Columns
        {
            public const string DocumentLevel = "DocumentLevel";
            public const string Title = "Title";
            public const string Owner = "Owner";
            public const string FolderFlag = "FolderFlag";
            public const string FileName = "FileName";
            public const string FileExtension = "FileExtension";
            public const string Revision = "Revision";
            public const string ChangeNumber = "ChangeNumber";
            public const string Status = "Status";
            public const string DocumentSummary = "DocumentSummary";
            public const string DocumentMember = "Document";
            public const string Rowguid = "rowguid";
            public const string ModifiedDate = "ModifiedDate";
        }
        #endregion
    }
}
