namespace AdventureWorks.Data.ViewModels
{
    public class ProductResponseModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductNumber { get; set; }

        public string Color { get; set; }

        public short SafetyStockLevel { get; set; }

        public decimal StandardCost { get; set; }

        public decimal ListPrice { get; set; }

        public decimal? Weight { get; set; }
    }
}
