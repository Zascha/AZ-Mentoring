using System;
using System.Collections.Generic;
using System.Dynamic;

namespace AdventureWorks.Data.Models
{
    /// <summary>
    /// Entity class representing data for table 'Document'.
    /// </summary>
    public partial class Document
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Document"/> class.
        /// </summary>
        public Document()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties

        public int DocumentId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DocumentLevel'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DocumentLevel'.
        /// </value>
        public short? DocumentLevel { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Title'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Title'.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Owner'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Owner'.
        /// </value>
        public int Owner { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FolderFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FolderFlag'.
        /// </value>
        public bool FolderFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FileName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FileName'.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FileExtension'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FileExtension'.
        /// </value>
        public string FileExtension { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Revision'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Revision'.
        /// </value>
        public string Revision { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ChangeNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ChangeNumber'.
        /// </value>
        public int ChangeNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Status'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Status'.
        /// </value>
        public byte Status { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DocumentSummary'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DocumentSummary'.
        /// </value>
        public string DocumentSummary { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Document'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Document'.
        /// </value>
        public Byte[] DocumentMember { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'rowguid'.
        /// </summary>
        /// <value>
        /// The property value representing column 'rowguid'.
        /// </value>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTime ModifiedDate { get; set; }

        #endregion

        #region Generated Relationships
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Employee" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Employee" />.
        /// </value>
        /// <seealso cref="Owner" />
        public virtual Employee OwnerEmployee { get; set; }

        #endregion

    }
}
