using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using AdventureWorks.CommomData;
using AdventureWorks.Common;
using AdventureWorks.Data.Models;
using AdventureWorks.Data.ViewModels;
using AdventureWorks.DataServices.Interfaces;
using AdventureWorks.DataServices.Mappers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AdventureWorks.API.Controllers
{
    /// <summary>
    /// Products API
    /// </summary>
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public readonly IApiService<Product> _productsService;
        private readonly ToResponseModelsMapper _mapper;

        public ProductsController(
            IApiService<Product> productsService,
            ToResponseModelsMapper mapper)
        {
            _productsService = productsService ?? throw new ArgumentNullException(nameof(productsService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Get a paged list of Products.
        /// </summary>
        /// <param name="pageNumber">Page number (default is 1).</param>
        /// <param name="pageSize">Page size (default is 50).</param>
        /// <returns>GetApiResponse with Items, HttpStatusCode and FailureReason data.</returns>
        [HttpGet("api/products/getAll")]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetApiResponse<ProductResponseModel>))]
        public ActionResult<GetApiResponse<ProductResponseModel>> GetAllProductsPaged(int pageNumber = 1, int pageSize = DataConsts.PageSize)
        {
            try
            {
                var productResponseModels = _productsService.GetAllPaged(pageNumber, pageSize)
                                                                  .Select(x => _mapper.ToProductResponseModel(x))
                                                                  .ToList();

                return new GetApiResponse<ProductResponseModel>
                {
                    Items = productResponseModels,
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch(Exception exception)
            {
                return new GetApiResponse<ProductResponseModel>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    FailureReason = exception.Message
                };
            }
        }

        /// <summary>
        /// Get a Product by ID.
        /// </summary>
        /// <param name="productId">Product id.</param>
        /// <returns>GetApiResponse with Items, HttpStatusCode and FailureReason data.</returns>
        [HttpGet("api/products/get")]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetApiResponse<ProductResponseModel>))]
        public ActionResult<GetApiResponse<ProductResponseModel>> GetProductById(int productId)
        {
            try
            {
                var product = _productsService.GetById(productId);
                var productResponseModel = _mapper.ToProductResponseModel(product);
                var productResponseModels = productResponseModel != null
                                          ? new List<ProductResponseModel> {productResponseModel}
                                          : new List<ProductResponseModel>();

                return new GetApiResponse<ProductResponseModel>
                {
                    Items = productResponseModels,
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception exception)
            {
                return new GetApiResponse<ProductResponseModel>
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    FailureReason = exception.Message
                };
            }
        }

        /// <summary>
        /// Create a Product.
        /// </summary>
        /// <param name="product">Product to create.</param>
        /// <returns>Status code with either create product id or error message.</returns>
        [HttpPost("api/products/create")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [SwaggerResponse((int) HttpStatusCode.OK, Type = typeof(GetApiResponse<Product>))]
        public ActionResult<HttpStatusCode> CreateProduct([FromBody] Product product)
        {
            try
            {
                var productId = _productsService.Create(product);

                return StatusCode(200, productId);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.Message);
            }
        }

        /// <summary>
        /// Update a Product.
        /// </summary>
        /// <param name="product">Product to update.</param>
        /// <returns>Status code.</returns>
        [HttpPost("api/products/update")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetApiResponse<Product>))]
        public ActionResult<HttpStatusCode> UpdateProduct([FromBody] Product product)
        {
            try
            {
                _productsService.Update(product);

                return StatusCode(200);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.Message);
            }
        }

        /// <summary>
        /// Delete a product by ID.
        /// </summary>
        /// <param name="productId">ID of a Product to delete.</param>
        /// <returns>Status code.</returns>
        [HttpPost("api/products/delete")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetApiResponse<Product>))]
        public ActionResult<HttpStatusCode> DeleteProduct(int productId)
        {
            try
            {
                _productsService.DeleteById(productId);

                return StatusCode(200);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception.Message);
            }
        }
    }
}
