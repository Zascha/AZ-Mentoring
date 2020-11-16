using AdventureWorks.Common;
using AdventureWorks.Data.Models;
using AdventureWorks.DataAccess.Interfaces;
using AdventureWorks.DataServices.Interfaces;
using AdventureWorks.DataServices.Services;
using FakeItEasy;
using System;
using System.Linq;
using Xunit;

namespace AdventureWorks.Tests
{
    public class ProductsServiceTests
    {
        private readonly IQuery<Product> _productQuery;
        private readonly Serilog.ILogger _logger;
        private readonly IApiService<Product> _productService;
        private readonly ProductsServiceTestsData _testData;

        public ProductsServiceTests()
        {
            _productQuery = A.Fake<IQuery<Product>>();
            _logger = A.Fake<Serilog.ILogger>();

            _productService = new ProductsService(_productQuery, _logger);
            _testData = new ProductsServiceTestsData();
        }

        [Fact]
        public void GetAllPaged__ReturnsListOfProducts()
        {
            A.CallTo(() => _productQuery.GetAllPaged(1, DataConsts.PageSize)).Returns(_testData.Products);

            var productsServiceResponse = _productService.GetAllPaged();

            A.CallTo(() => _productQuery.GetAllPaged(1, DataConsts.PageSize)).MustHaveHappenedOnceExactly();
            Assert.True(productsServiceResponse.Any());
        }

        [Fact]
        public void GetById_ExistingId_ReturnsProduct()
        {
            var existingProductId = 1;
            A.CallTo(() => _productQuery.GetById(existingProductId)).Returns(_testData.Product);

            var productsServiceResponse = _productService.GetById(existingProductId);

            A.CallTo(() => _productQuery.GetById(existingProductId)).MustHaveHappenedOnceExactly();
            Assert.NotNull(productsServiceResponse);
            Assert.Equal(existingProductId, productsServiceResponse.ProductID);
        }

        [Fact]
        public void GetById_NotExistingId_ReturnsNull()
        {
            var notExistingProductId = 1;
            A.CallTo(() => _productQuery.GetById(notExistingProductId)).Returns(null);

            var productsServiceResponse = _productService.GetById(notExistingProductId);

            A.CallTo(() => _productQuery.GetById(notExistingProductId)).MustHaveHappenedOnceExactly();
            Assert.Null(productsServiceResponse);
        }

        [Fact]
        public void Create_ProductIsNull_ThrowsArgumentNullException()
        {
            Product nullProduct = null;

            Assert.Throws<ArgumentNullException>(() => _productService.Create(nullProduct));
            A.CallTo(() => _productQuery.Create(nullProduct)).MustNotHaveHappened();
            A.CallTo(() => _logger.Error(A<string>._, A<Exception>._)).MustNotHaveHappened();
        }

        [Fact]
        public void Create_ProductIsNotNull_QueryThrowsException_ThrowsException()
        {
            var product = _testData.Product;

            A.CallTo(() => _productQuery.Create(product)).Throws(new InvalidOperationException());

            Assert.Throws<InvalidOperationException>(() => _productService.Create(product));
            A.CallTo(() => _productQuery.Create(product)).MustHaveHappenedOnceExactly();
            A.CallTo(() => _logger.Error(A<string>._, A<Exception>._)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Create_ProductIsNotNull_ReturnsCreatedProductId()
        {
            var product = _testData.Product;
            var createdProductId = 1;

            A.CallTo(() => _productQuery.Create(product)).Returns(createdProductId);

            var productsServiceResponse = _productService.Create(product);

            A.CallTo(() => _productQuery.Create(product)).MustHaveHappenedOnceExactly();
            A.CallTo(() => _logger.Error(A<string>._, A<Exception>._)).MustNotHaveHappened();
            Assert.Equal(createdProductId, productsServiceResponse);
        }

        [Fact]
        public void Update_ProductIsNull_ThrowsArgumentNullException()
        {
            Product nullProduct = null;

            Assert.Throws<ArgumentNullException>(() => _productService.Update(nullProduct));
            A.CallTo(() => _productQuery.Update(nullProduct)).MustNotHaveHappened();
            A.CallTo(() => _logger.Error(A<string>._, A<Exception>._)).MustNotHaveHappened();
        }

        [Fact]
        public void Update_ProductIsNotNull_QueryThrowsException_ThrowsException()
        {
            var product = _testData.Product;

            A.CallTo(() => _productQuery.Update(product)).Throws(new InvalidOperationException());

            Assert.Throws<InvalidOperationException>(() => _productService.Update(product));
            A.CallTo(() => _productQuery.Update(product)).MustHaveHappenedOnceExactly();
            A.CallTo(() => _logger.Error(A<string>._, A<Exception>._)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Update_ProductIsNotNull_UpdatesProduct()
        {
            var product = _testData.Product;

            _productService.Update(product);

            A.CallTo(() => _productQuery.Update(product)).MustHaveHappenedOnceExactly();
            A.CallTo(() => _logger.Error(A<string>._, A<Exception>._)).MustNotHaveHappened();
        }

        [Fact]
        public void DeleteById_ProductIsNotNull_QueryThrowsException_ThrowsException()
        {
            var productId = 1;

            A.CallTo(() => _productQuery.DeleteById(productId)).Throws(new InvalidOperationException());

            Assert.Throws<InvalidOperationException>(() => _productService.DeleteById(productId));
            A.CallTo(() => _productQuery.DeleteById(productId)).MustHaveHappenedOnceExactly();
            A.CallTo(() => _logger.Error(A<string>._, A<Exception>._)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void DeleteById_DeletesProduct()
        {
            var productId = 1;

            _productService.DeleteById(productId);

            A.CallTo(() => _productQuery.DeleteById(productId)).MustHaveHappenedOnceExactly();
            A.CallTo(() => _logger.Error(A<string>._, A<Exception>._)).MustNotHaveHappened();
        }
    }
}