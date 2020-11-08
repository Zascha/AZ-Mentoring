using AdventureWorks.Data.Models;
using AdventureWorks.Data.ViewModels;

namespace AdventureWorks.DataServices.Mappers
{
    public class ToResponseModelsMapper
    {
        public ProductResponseModel ToProductResponseModel(Product item)
        {
            if (item == null)
            {
                return null;
            }

            return new ProductResponseModel
            {
                ProductId = item.ProductID,
                ProductName = item.Name,
                ProductNumber = item.ProductNumber,
                Color = item.Color,
                ListPrice = item.ListPrice,
                SafetyStockLevel = item.SafetyStockLevel,
                StandardCost = item.StandardCost,
                Weight = item.Weight
            };
        }
    }
}