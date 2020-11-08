using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Models
{
    /// <summary>
    /// Entity class representing data for table 'ProductDocument'.
    /// </summary>
    public partial class ProductDocument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDocument"/> class.
        /// </summary>
        public ProductDocument()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Product" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Product" />.
        /// </value>
        /// <seealso cref="ProductID" />
        public virtual Product Product { get; set; }

        #endregion

    }
}
