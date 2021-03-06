using System;
using System.Collections.Generic;

namespace AdventureWorks.Data.Models
{
    /// <summary>
    /// Entity class representing data for table 'Address'.
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
            #region Generated Constructor
            BillToSalesOrderHeaders = new HashSet<SalesOrderHeader>();
            BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
            ShipToSalesOrderHeaders = new HashSet<SalesOrderHeader>();
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'AddressID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressID'.
        /// </value>
        public int AddressID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AddressLine1'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressLine1'.
        /// </value>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AddressLine2'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressLine2'.
        /// </value>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'City'.
        /// </summary>
        /// <value>
        /// The property value representing column 'City'.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StateProvinceID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StateProvinceID'.
        /// </value>
        public int StateProvinceID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PostalCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PostalCode'.
        /// </value>
        public string PostalCode { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </value>
        public virtual ICollection<SalesOrderHeader> BillToSalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="BusinessEntityAddress" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="BusinessEntityAddress" />.
        /// </value>
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </value>
        public virtual ICollection<SalesOrderHeader> ShipToSalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="StateProvince" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="StateProvince" />.
        /// </value>
        /// <seealso cref="StateProvinceID" />
        public virtual StateProvince StateProvince { get; set; }

        #endregion

    }
}
