using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Sirius.MS.Service.Helpers;
using Sirius.MS.BAL.Managers.Interfaces;
using Sirius.MS.BAL.Managers;
using Sirius.MS.BAL.Models;
using Sirius.MS.DAL.Entities;

namespace Sirius.MS.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;
        private readonly IApiResponse _apiResponse;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductController> _logger;

        [ActivatorUtilitiesConstructor]
        public ProductController(IMapper mapper, ILogger<ProductController> logger)
        {
            _productManager = new ProductManager();
            _apiResponse = new ApiResponse();
            _apiResponse.Success = false;
            _mapper = mapper;
            _logger = logger;
        }

        //UnitTest Constructor
        public ProductController(IProductManager ProductManager, IMapper mapper, ILogger<ProductController> logger)
        {
            _productManager = ProductManager;
            _apiResponse = new ApiResponse();
            _mapper = mapper;
            _logger = logger;
        }


        [HttpGet(VBooksServiceAPIUrls.LoadList)]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> LoadList()
        {
            try
            {

                var productList = await _productManager.LoadList();
                // Auto Mapper from product entity to  productModel
                var ProductModelList = _mapper.Map<List<ProductModel>>(productList);
                if (ProductModelList == null)
                {
                    ProductModelList = new List<ProductModel>();
                    _apiResponse.Message = ConstantMessages.NoRecordsFound.Replace("{event}", "Product");
                }
                else
                {
                    _apiResponse.Message = ConstantMessages.Load.Replace("{event}", "Product");
                }
                _logger.LogInformation(_apiResponse.Message);
                _apiResponse.Success = true;
                _apiResponse.ResponseObject = ProductModelList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Occurred while getting the GetProductList");
            }

            return Ok(_apiResponse);
        }

        // GET api/<controller>/5

        [HttpGet(VBooksServiceAPIUrls.LoadById)]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> LoadById(long id)
        {

            try
            {
                if (!string.IsNullOrEmpty(Convert.ToString(id)))
                {
                    var product = await _productManager.Load(id);
                    if (product == null)
                    {
                        _logger.LogInformation(ConstantMessages.LoadFailure.Replace("{event}", "Product") + " for {id}", id);
                        return BadRequest(ConstantMessages.LoadFailure.Replace("{event}", "Product"));
                    }
                    else
                    {
                        // Auto Mapper from product entity to  productModel
                        var ProductModel = _mapper.Map<ProductModel>(product);
                        _apiResponse.Success = true;
                        _apiResponse.Message = ConstantMessages.Load.Replace("{event}", "Product");
                        _apiResponse.ResponseObject = ProductModel;
                        _logger.LogInformation(_apiResponse.Message);
                    }
                }
                else
                {
                    _apiResponse.Message = ConstantMessages.InvalidParameter;
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Occurred while getting the GetProductListById {id}", id);
            }
            return Ok(_apiResponse);
        }

        [HttpGet(VBooksServiceAPIUrls.ProductApiUrl.GetProductByCode)]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetProductByCode(string code)
        {
            try
            {
                if (!string.IsNullOrEmpty(code))
                {
                    var product = await _productManager.GetProductByCode(code.Trim());
                    if (product == null)
                    {
                        _logger.LogInformation(ConstantMessages.NoRecordsFound.Replace("{event}", "Product") + " for {code}", code);
                        return BadRequest(ConstantMessages.NoRecordsFound.Replace("{event}", "Product"));
                    }
                    else
                    {
                        // Auto Mapper from product entity to  productModel
                        var ProductModel = _mapper.Map<ProductModel>(product);
                        _apiResponse.Message = ConstantMessages.Load.Replace("{event}", "Product");
                        _logger.LogInformation(_apiResponse.Message + " for {code}", code);
                        _apiResponse.Success = true;
                        _apiResponse.ResponseObject = ProductModel;
                    }
                }
                else
                {
                    _apiResponse.Message = ConstantMessages.InvalidParameter;

                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Occurred while getting the GetProductByCode{code}", code);
            }
            return Ok(_apiResponse);
        }

        // POST api/<controller>

        [HttpPost(VBooksServiceAPIUrls.Create)]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Create([FromBody] ProductModel ProductModel)
        {
            try
            {
                // Auto Mapper from productModel to entity 
                var productModel = _mapper.Map<Product>(ProductModel);

                var result = await _productManager.Create(productModel);
                if (result > 0)
                {
                    _apiResponse.Success = true;
                    _apiResponse.Message = ConstantMessages.Create.Replace("{event}", "Product");
                    _apiResponse.ResponseObject = result;
                    _logger.LogInformation(_apiResponse.Message);
                }
                else
                {
                    _logger.LogInformation(ConstantMessages.CreateFailure.Replace("{event}", "Product"));
                    return BadRequest(ConstantMessages.CreateFailure.Replace("{event}", "Product"));
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Occurred while create new Product {objProduct}", ProductModel);
            }
            return Ok(_apiResponse);
        }

        // PUT api/<controller>/5
        [HttpPut(VBooksServiceAPIUrls.Update)]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Update([FromBody] ProductModel ProductModel)
        {
            try
            {

                // Auto Mapper from productModel to entity 
                var productModel = _mapper.Map<Product>(ProductModel);

                var result = await _productManager.Update(productModel);
                if (!result)
                {
                    _logger.LogInformation(ConstantMessages.UpdateFailure.Replace("{event}", "Product"));
                    return BadRequest(ConstantMessages.UpdateFailure.Replace("{event}", "Product"));
                }
                _apiResponse.Success = true;
                _apiResponse.Message = ConstantMessages.Update.Replace("{event}", "Product");
                _apiResponse.ResponseObject = result;
                _logger.LogInformation(_apiResponse.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Occurred while update Product {objProduct}", ProductModel);
            }
            return Ok(_apiResponse);
        }

        // DELETE api/<controller>/5

        [HttpDelete(VBooksServiceAPIUrls.Delete)]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Delete(long id)
        {
            try
            {
                var result = await _productManager.Delete(id);
                if (!result)
                {
                    _logger.LogInformation(ConstantMessages.DeleteFailure.Replace("{event}", "Product"));
                    return BadRequest(ConstantMessages.DeleteFailure.Replace("{event}", "Product"));
                }
                _apiResponse.Success = true;
                _apiResponse.Message = ConstantMessages.Delete.Replace("{event}", "Product");
                _apiResponse.ResponseObject = result;
                _logger.LogInformation(_apiResponse.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Occurred while delete Product for {ProductId}", id);
            }
            return Ok(_apiResponse);
        }

    }
}
