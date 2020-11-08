using System;
using AdventureWorks.Data.Models;
using AdventureWorks.DataServices.Interfaces;
using System.Collections.Generic;
using AdventureWorks.Common;
using AdventureWorks.Common.Interfaces;
using AdventureWorks.DataAccess.Interfaces;
using Newtonsoft.Json;

namespace AdventureWorks.DataServices.Services
{
    public class ProductsService : IApiService<Product>
    {
        private readonly IQuery<Product> _productQuery;
        private readonly Serilog.ILogger _logger;

        public ProductsService(
            IQuery<Product> productQuery,
            Serilog.ILogger logger)
        {
            _productQuery = productQuery ?? throw new ArgumentNullException(nameof(productQuery));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public List<Product> GetAllPaged(int pageNumber = 1, int pageSize = DataConsts.PageSize)
        {
            return _productQuery.GetAllPaged(pageNumber, pageSize);
        }

        public Product GetById(int itemId)
        {
            return _productQuery.GetById(itemId);
        }

        public int Create(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            try
            {
                var createdProductId = _productQuery.Create(item);

                return createdProductId;
            }
            catch (Exception exception)
            {
                _logger.Error($"Exception has occurred while creating Product: {JsonConvert.SerializeObject(item, Formatting.None)}. Exception: {exception.Message}.", exception);

                throw;
            }
        }
        
        public void Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            try
            {
                _productQuery.Update(item);
            }
            catch (Exception exception)
            {
                _logger.Error($"Exception has occurred while updating Product: {JsonConvert.SerializeObject(item, Formatting.None)}. Exception: {exception.Message}.", exception);

                throw;
            }
        }

        public void DeleteById(int itemId)
        {
            try
            {
                _productQuery.DeleteById(itemId);
            }
            catch (Exception exception)
            {
                _logger.Error($"Exception has occurred while deleting Product {itemId}. Exception: {exception.Message}.", exception);

                throw;
            }
        }
    }
}