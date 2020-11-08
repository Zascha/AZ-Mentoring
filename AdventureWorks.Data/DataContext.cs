using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data
{
    /// <summary>
    /// A <see cref="DbContext" /> instance represents a session with the database and can be used to query and save instances of entities. 
    /// </summary>
    public partial class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        /// <param name="options">The options to be used by this <see cref="DbContext" />.</param>
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Address"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Address"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.AddressType"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.AddressType"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.AddressType> AddressTypes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.AWBuildVersion"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.AWBuildVersion"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.AWBuildVersion> AWBuildVersions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.BillOfMaterials"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.BillOfMaterials"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.BillOfMaterials> BillOfMaterials { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.BusinessEntity"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.BusinessEntity"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.BusinessEntity> BusinessEntities { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.BusinessEntityAddress"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.BusinessEntityAddress"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.BusinessEntityAddress> BusinessEntityAddresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.BusinessEntityContact"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.BusinessEntityContact"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.BusinessEntityContact> BusinessEntityContacts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ContactType"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ContactType"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ContactType> ContactTypes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.CountryRegionCurrency"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.CountryRegionCurrency"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.CountryRegionCurrency> CountryRegionCurrencies { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.CountryRegion"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.CountryRegion"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.CountryRegion> CountryRegions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.CreditCard"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.CreditCard"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.CreditCard> CreditCards { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Culture"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Culture"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Culture> Cultures { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Currency"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Currency"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Currency> Currencies { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.CurrencyRate"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.CurrencyRate"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.CurrencyRate> CurrencyRates { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Customer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Customer"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.DatabaseLog"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.DatabaseLog"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.DatabaseLog> DatabaseLogs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Department"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Department"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Department> Departments { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Document"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Document"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Document> Documents { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.EmailAddress"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.EmailAddress"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.EmailAddress> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.EmployeeDepartmentHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.EmployeeDepartmentHistory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.EmployeePayHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.EmployeePayHistory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.EmployeePayHistory> EmployeePayHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Employee"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Employee"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Employee> Employees { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ErrorLog"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ErrorLog"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ErrorLog> ErrorLogs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Illustration"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Illustration"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Illustration> Illustrations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.JobCandidate"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.JobCandidate"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.JobCandidate> JobCandidates { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Location"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Location"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Location> Locations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Password"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Password"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Password> Passwords { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Person"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Person"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Person> People { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.PersonCreditCard"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.PersonCreditCard"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.PersonCreditCard> PersonCreditCards { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.PersonPhone"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.PersonPhone"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.PersonPhone> PersonPhones { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.PhoneNumberType"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.PhoneNumberType"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.PhoneNumberType> PhoneNumberTypes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductCategory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductCategory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductCategory> ProductCategories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductCostHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductCostHistory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductCostHistory> ProductCostHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductDescription"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductDescription> ProductDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductDocument"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductDocument"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductDocument> ProductDocuments { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductInventory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductInventory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductInventory> ProductInventories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductListPriceHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductListPriceHistory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductListPriceHistory> ProductListPriceHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductModelIllustration"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductModelIllustration"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductModelIllustration> ProductModelIllustrations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductModelProductDescriptionCulture"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductModelProductDescriptionCulture"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductModel"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductModel"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductModel> ProductModels { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductPhoto"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductPhoto"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductPhoto> ProductPhotos { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductProductPhoto"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductProductPhoto"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductProductPhoto> ProductProductPhotos { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductReview"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductReview"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductReview> ProductReviews { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Product"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Product"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductSubcategory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductSubcategory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductSubcategory> ProductSubcategories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductVendor"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ProductVendor"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ProductVendor> ProductVendors { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.PurchaseOrderDetail"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.PurchaseOrderDetail"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.PurchaseOrderHeader"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.PurchaseOrderHeader"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesOrderDetail"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesOrderDetail"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SalesOrderDetail> SalesOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesOrderHeader"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesOrderHeader"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesOrderHeaderSalesReason"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesOrderHeaderSalesReason"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesPerson"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesPerson"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SalesPerson> SalesPeople { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesPersonQuotaHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesPersonQuotaHistory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesReason"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesReason"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SalesReason> SalesReasons { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesTaxRate"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesTaxRate"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SalesTaxRate> SalesTaxRates { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesTerritory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesTerritory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SalesTerritory> SalesTerritories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesTerritoryHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SalesTerritoryHistory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ScrapReason"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ScrapReason"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ScrapReason> ScrapReasons { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Shift"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Shift"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Shift> Shifts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ShipMethod"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ShipMethod"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ShipMethod> ShipMethods { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ShoppingCartItem"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.ShoppingCartItem"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.ShoppingCartItem> ShoppingCartItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SpecialOfferProduct"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SpecialOfferProduct"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SpecialOfferProduct> SpecialOfferProducts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SpecialOffer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.SpecialOffer"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.SpecialOffer> SpecialOffers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.StateProvince"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.StateProvince"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.StateProvince> StateProvinces { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Store"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Store"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Store> Stores { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.TransactionHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.TransactionHistory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.TransactionHistory> TransactionHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.TransactionHistoryArchive"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.TransactionHistoryArchive"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.TransactionHistoryArchive> TransactionHistoryArchives { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.UnitMeasure"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.UnitMeasure"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.UnitMeasure> UnitMeasures { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VAdditionalContactInfo"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VAdditionalContactInfo"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VAdditionalContactInfo> VAdditionalContactInfos { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VEmployeeDepartmentHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VEmployeeDepartmentHistory"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VEmployeeDepartmentHistory> VEmployeeDepartmentHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VEmployeeDepartment"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VEmployeeDepartment"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VEmployeeDepartment> VEmployeeDepartments { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VEmployee"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VEmployee"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VEmployee> VEmployees { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Vendor"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.Vendor"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.Vendor> Vendors { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VIndividualCustomer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VIndividualCustomer"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VIndividualCustomer> VIndividualCustomers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VJobCandidateEducation"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VJobCandidateEducation"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VJobCandidateEducation> VJobCandidateEducations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VJobCandidateEmployment"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VJobCandidateEmployment"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VJobCandidateEmployment> VJobCandidateEmployments { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VJobCandidate"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VJobCandidate"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VJobCandidate> VJobCandidates { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VPersonDemographics"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VPersonDemographics"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VPersonDemographics> VPersonDemographics { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VProductAndDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VProductAndDescription"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VProductAndDescription> VProductAndDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VProductModelCatalogDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VProductModelCatalogDescription"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VProductModelCatalogDescription> VProductModelCatalogDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VProductModelInstructions"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VProductModelInstructions"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VProductModelInstructions> VProductModelInstructions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VSalesPerson"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VSalesPerson"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VSalesPerson> VSalesPeople { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VSalesPersonSalesByFiscalYears"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VSalesPersonSalesByFiscalYears"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VSalesPersonSalesByFiscalYears> VSalesPersonSalesByFiscalYears { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VStateProvinceCountryRegion"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VStateProvinceCountryRegion"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VStateProvinceCountryRegion> VStateProvinceCountryRegions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VStoreWithAddresses"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VStoreWithAddresses"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VStoreWithAddresses> VStoreWithAddresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VStoreWithContacts"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VStoreWithContacts"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VStoreWithContacts> VStoreWithContacts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VStoreWithDemographics"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VStoreWithDemographics"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VStoreWithDemographics> VStoreWithDemographics { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VVendorWithAddresses"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VVendorWithAddresses"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VVendorWithAddresses> VVendorWithAddresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VVendorWithContacts"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.VVendorWithContacts"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.VVendorWithContacts> VVendorWithContacts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.WorkOrderRouting"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.WorkOrderRouting"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.WorkOrderRouting> WorkOrderRoutings { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.WorkOrder"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdventureWorks.Data.Models.WorkOrder"/>.
        /// </value>
        public virtual DbSet<AdventureWorks.Data.Models.WorkOrder> WorkOrders { get; set; }

        #endregion

        /// <summary>
        /// Configure the model that was discovered from the entity types exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on this context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.AddressMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.AddressTypeMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.AWBuildVersionMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.BillOfMaterialsMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.BusinessEntityAddressMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.BusinessEntityContactMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.BusinessEntityMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ContactTypeMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.CountryRegionCurrencyMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.CountryRegionMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.CreditCardMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.CultureMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.CurrencyMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.CurrencyRateMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.CustomerMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.DatabaseLogMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.DepartmentMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.DocumentMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.EmailAddressMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.EmployeeDepartmentHistoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.EmployeeMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.EmployeePayHistoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ErrorLogMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.IllustrationMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.JobCandidateMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.LocationMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.PasswordMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.PersonCreditCardMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.PersonMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.PersonPhoneMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.PhoneNumberTypeMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductCategoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductCostHistoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductDescriptionMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductDocumentMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductInventoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductListPriceHistoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductModelIllustrationMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductModelMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductModelProductDescriptionCultureMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductPhotoMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductProductPhotoMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductReviewMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductSubcategoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ProductVendorMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.PurchaseOrderDetailMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.PurchaseOrderHeaderMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SalesOrderDetailMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SalesOrderHeaderMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SalesOrderHeaderSalesReasonMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SalesPersonMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SalesPersonQuotaHistoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SalesReasonMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SalesTaxRateMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SalesTerritoryHistoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SalesTerritoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ScrapReasonMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ShiftMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ShipMethodMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.ShoppingCartItemMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SpecialOfferMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.SpecialOfferProductMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.StateProvinceMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.StoreMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.TransactionHistoryArchiveMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.TransactionHistoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.UnitMeasureMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VAdditionalContactInfoMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VEmployeeDepartmentHistoryMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VEmployeeDepartmentMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VEmployeeMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VendorMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VIndividualCustomerMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VJobCandidateEducationMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VJobCandidateEmploymentMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VJobCandidateMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VPersonDemographicsMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VProductAndDescriptionMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VProductModelCatalogDescriptionMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VProductModelInstructionsMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VSalesPersonMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VSalesPersonSalesByFiscalYearsMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VStateProvinceCountryRegionMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VStoreWithAddressesMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VStoreWithContactsMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VStoreWithDemographicsMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VVendorWithAddressesMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.VVendorWithContactsMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.WorkOrderMap());
            modelBuilder.ApplyConfiguration(new AdventureWorks.Data.Models.Mapping.WorkOrderRoutingMap());
            #endregion
        }
    }
}
