using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Sirius.MS.Service.Controllers;
using Sirius.MS.BAL.Managers.Interfaces;
using Sirius.MS.BAL.Models;
using Sirius.MS.DAL.Entities;
using Sirius.MS.UnitTests.Mapper;
using Sirius.MS.UnitTests.Mocks.BAL.Managers;

namespace Sirius.MS.UnitTests.Controllers
{
    [TestFixture]
    public class ProductControllerTest
    {

        private ProductController _productController;
        private Mock<ILogger<ProductController>> _mockLogger;
        private MockProductManager mockProductManager;
        private IApiResponse _mockResponse;
        private int _ProductListCount;
        private int _ProductListMaxId;
        private IMapper _mockMapper;
        // create some mock products to play with
        private IList<Product> _ProductList;

        [SetUp]
        public void SetUp()
        {
            //Arrange
            #region "Arrange"

            //Creating Dummy Product List
            _ProductList = new List<Product>
                    {
                        new Product {Id = 1,
                                    ProdSname = "Test Product 1",
                                    ProdLname = "Test Product 1",
                                    ProdCode = "test1",
                                    GmidUnit =1,
                                    MinQty =10,
                                    ReorderQty =10,
                                    ActiveStatus ="A",
                                    DeleteStatus ="A"
                         },
                         new Product {Id = 2,
                                    ProdSname = "Test Product 2",
                                    ProdLname = "Test Product 2",
                                    ProdCode = "test2",
                                    GmidUnit =1,
                                    MinQty =10,
                                    ReorderQty =10,
                                    ActiveStatus ="A",
                                    DeleteStatus ="A"
                         },
                          new Product {Id = 3,
                                    ProdSname = "Test Product 3",
                                    ProdLname = "Test Product 3",
                                    ProdCode = "test3",
                                    GmidUnit =1,
                                    MinQty =10,
                                    ReorderQty =10,
                                    ActiveStatus ="A",
                                    DeleteStatus ="A"
                         },
                           new Product {Id = 4,
                                    ProdSname = "Test Product 4",
                                    ProdLname = "Test Product 4",
                                    ProdCode = "test4",
                                    GmidUnit =1,
                                    MinQty =10,
                                    ReorderQty =10,
                                    ActiveStatus ="A",
                                    DeleteStatus ="A"
                         }

                    };

            //logger
            _mockLogger = new Mock<ILogger<ProductController>>();

            // Mock the API Response 
            _mockResponse = new ApiResponse();

            //Mapper Configuration
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MockMappingProfile());
            });
            _mockMapper = mappingConfig.CreateMapper();

            #endregion

            //Setup MockProductManager
            mockProductManager = new MockProductManager();

        }

        /// <summary>
        /// Can we Load a Product By Id?
        /// </summary>
        [TestCase]
        public void Product_LoadProductById_Valid()
        {
            //Arrange

            // Get that Product for id : 2
            Product testProduct = mockProductManager.MockFindById(_ProductList, 2);

            var mockProductManagerResult = new MockProductManager().MockLoad(testProduct);

            _productController = new ProductController(
                                      mockProductManagerResult.Result.Object,
                                      _mockMapper,
                                      _mockLogger.Object);

            //Act  
            var actionResult = _productController.LoadById(2);
            var actionResponse = actionResult.Result as OkObjectResult;
            _mockResponse = actionResponse.Value as ApiResponse;
            var dataResult = _mockResponse.ResponseObject as ProductModel;

            //Assert  
            Assert.IsInstanceOf(typeof(OkObjectResult), actionResponse); //Test if returns ok response  
            Assert.IsNotNull(dataResult); // Test if null
            Assert.IsInstanceOf(typeof(ProductModel), dataResult); //Test if returns ok response   
        }

        /// <summary>
        /// if we not Load a Product By Id?
        /// </summary>
        [TestCase]
        public void Product_LoadProductById_InValid()
        {
            //Arrange

            // Get that Product for id : 6
            Product testProduct = mockProductManager.MockFindById(_ProductList, 6);

            var mockProductManagerResult = new MockProductManager().MockLoad(testProduct);

            _productController = new ProductController(
                                      mockProductManagerResult.Result.Object,
                                      _mockMapper,
                                      _mockLogger.Object);

            //Act  
            var actionResult = _productController.LoadById(2);
            var actionResponse = actionResult.Result as BadRequestObjectResult;

            //Assert  
            Assert.IsInstanceOf(typeof(BadRequestObjectResult), actionResponse); //Test if returns ok response  
        }

        /// <summary>
        /// Can we Load all Products?
        /// </summary>
        [TestCase]
        public void Product_LoadProduct_Valid()
        {
            //Arrange
            // Loading all Product
            var mockProductManagerResult = new MockProductManager().MockLoadList(_ProductList);

            //Setup ProductController
            _productController = new ProductController(
                                        mockProductManagerResult.Result.Object,
                                        _mockMapper,
                                        _mockLogger.Object);

            //Act  
            var actionResult = _productController.LoadList();
            var actionResponse = actionResult.Result as OkObjectResult;
            _mockResponse = actionResponse.Value as ApiResponse;
            var dataResult = _mockResponse.ResponseObject as List<ProductModel>;

            //Get Actual Count
            _ProductListCount = _ProductList.Count;

            //Assert  
            Assert.IsInstanceOf(typeof(OkObjectResult), actionResponse); //Test if returns ok response            
            Assert.AreEqual(dataResult.Count, _ProductListCount); // Verify the correct Number
        }

        /// <summary>
        /// If we have no records in Products?
        /// </summary>
        [TestCase]
        public void Product_LoadProduct_NoRecords()
        {

            //Arrange
            // Loading all Product
            var mockProductManagerResult = new MockProductManager().MockLoadList(null);

            //Setup ProductController
            _productController = new ProductController(
                                        mockProductManagerResult.Result.Object,
                                        _mockMapper,
                                        _mockLogger.Object);

            //Act  
            var actionResult = _productController.LoadList();
            var actionResponse = actionResult.Result as OkObjectResult;
            _mockResponse = actionResponse.Value as ApiResponse;
            var dataResult = _mockResponse.ResponseObject as List<ProductModel>;


            //Get Actual Count
            _ProductListCount = _ProductList.Count;

            //Assert  
            Assert.AreEqual(0, dataResult.Count); //Test if returns ok response 
        }

        /// <summary>
        /// Product event exists in Signup
        /// </summary>
        [TestCase]
        public void Product_Code_Exists()
        {

            //Arrange  
            // Get that Product for code : test
            Product testProduct = mockProductManager.MockFindByCode(_ProductList, "test1");

            var mockProductManagerResult = new MockProductManager().MockGetProductByCode(testProduct, _ProductList, "test1");
            _productController = new ProductController(
                                      mockProductManagerResult.Result.Object,
                                      _mockMapper,
                                      _mockLogger.Object);

            //ACT
            // Save our changes.
            var actionResult = _productController.GetProductByCode("test1");
            var actionResponse = actionResult.Result as OkObjectResult;
            _mockResponse = actionResponse.Value as ApiResponse;
            var dataResult = _mockResponse.ResponseObject as ProductModel;


            //Assert
            // Verify the change
            Assert.IsInstanceOf(typeof(OkObjectResult), actionResponse); //Test if returns ok response  
            Assert.IsInstanceOf(typeof(ProductModel), dataResult); // Test if true           
        }
        /// <summary>
        /// Product event Notexists in Signup
        /// </summary>
        [TestCase]
        public void Product_Code_NotExists()
        {

            //Arrange  
            // Get that Product for code : test
            Product testProduct = mockProductManager.MockFindByCode(_ProductList, "test15");

            var mockProductManagerResult = new MockProductManager().MockGetProductByCode(testProduct, _ProductList, "test15");
            _productController = new ProductController(
                                      mockProductManagerResult.Result.Object,
                                      _mockMapper,
                                      _mockLogger.Object);

            //ACT
            // Save our changes.
            var actionResult = _productController.GetProductByCode("test15");
            var actionResponse = actionResult.Result as BadRequestObjectResult;


            //Assert
            // Verify the change
            Assert.IsInstanceOf(typeof(BadRequestObjectResult), actionResponse); //Test if returns ok response    
        }

        ///// <summary>
        ///// Can we insert a new Product?
        ///// </summary>
        [TestCase]
        public void Product_Create_Valid()
        {
            //Get Actual Count
            _ProductListCount = _ProductList.Count;

            //Get Max ID from List
            _ProductListMaxId = Convert.ToInt32(_ProductList.Max(x => x.Id).ToString()) + 1;

            // Create a new ProductModel, not I do not supply an id
            ProductModel newProductModel = new ProductModel
            {
                Id = _ProductListMaxId,
                ProdSname = "Test Product " + _ProductListMaxId.ToString(),
                ProdCode = "test5",

            };

            // Auto Mapper from ProductModel to Product 
            var newProduct = _mockMapper.Map<Product>(newProductModel);

            //Arrange
            var mockProductManagerResult = new MockProductManager().MockCreate(1, _ProductList, newProduct);
            _productController = new ProductController(
                                      mockProductManagerResult.Result.Object,
                                      _mockMapper,
                                      _mockLogger.Object);


            //ACT
            #region "ACT"

            // try saving our new Product
            var actionResult = _productController.Create(newProductModel);
            var actionResponse = actionResult.Result as OkObjectResult;
            _mockResponse = actionResponse.Value as ApiResponse;
            var dataResult = Convert.ToBoolean(_mockResponse.ResponseObject);

            #endregion


            //Get Expected Count
            var expectedCount = _ProductList.Count;

            // Verify that our new Product has been created
            Product testProduct = mockProductManager.MockFindById(_ProductList, _ProductListMaxId);

            // Assert
            #region "Assert"            
            Assert.IsInstanceOf(typeof(OkObjectResult), actionResponse); //Test if returns ok response  
            Assert.IsTrue(dataResult); // Test if true
            Assert.IsInstanceOf(typeof(Product), testProduct); // Test type
            // Check both actual and expected count is same after insert        
            Assert.AreEqual(expectedCount, _ProductListCount + 1); // Verify the expected Number post-insert

            Assert.AreEqual(_ProductListMaxId, testProduct.Id); // Verify it has the expected Product Id

            #endregion
        }

        /// <summary>
        /// Can we insert a new Product?
        /// </summary>
        [TestCase]
        public void Product_Create_InValidData()
        {
            //Get Actual Count
            _ProductListCount = _ProductList.Count;

            //Get Max ID from List
            _ProductListMaxId = Convert.ToInt32(_ProductList.Max(x => x.Id).ToString()) + 1;

            // Create a new ProductModel, not I do not supply an id
            ProductModel newProductModel = new ProductModel
            {
                Id = _ProductListMaxId,
                ProdSname = "Test Product " + _ProductListMaxId.ToString(),
                ProdCode = "test12"
            };

            // Auto Mapper from ProductModel to Product 
            var newProduct = _mockMapper.Map<Product>(newProductModel);

            //Arrange
            var mockProductManagerResult = new MockProductManager().MockCreate(0, _ProductList, newProduct);
            _productController = new ProductController(
                                      mockProductManagerResult.Result.Object,
                                      _mockMapper,
                                      _mockLogger.Object);


            //ACT
            #region "ACT"

            // try saving our new Product
            var actionResult = _productController.Create(newProductModel);
            var actionResponse = actionResult.Result as BadRequestObjectResult;


            #endregion

            //Get Expected Count
            var expectedCount = _ProductList.Count;

            // Assert
            #region "Assert"            
            Assert.IsInstanceOf(typeof(BadRequestObjectResult), actionResponse); //Test if returns ok response           

            // Check both actual and expected count is same after insert        
            Assert.AreEqual(expectedCount, _ProductListCount); // Verify the expected Number post-insert

            #endregion
        }

        /// <summary>
        /// Can we update a Product?
        /// </summary>
        [TestCase]
        public void Product_Update_Valid()
        {

            //Arrange
            // Find a Product by id
            Product testProduct = mockProductManager.MockFindById(_ProductList, 3);

            // Change one of its properties
            testProduct.ProdSname = "Unit Test Data";

            // Auto Mapper from Product to ProductModel 
            var updateProduct = _mockMapper.Map<ProductModel>(testProduct);

            var mockProductManagerResult = new MockProductManager().MockUpdate(true, _ProductList, testProduct);
            _productController = new ProductController(
                                      mockProductManagerResult.Result.Object,
                                      _mockMapper,
                                      _mockLogger.Object);

            //ACT
            // Save our changes.
            var actionResult = _productController.Update(updateProduct);
            var actionResponse = actionResult.Result as OkObjectResult;
            _mockResponse = actionResponse.Value as ApiResponse;
            var dataResult = Convert.ToBoolean(_mockResponse.ResponseObject);

            //Assert
            // Verify the change
            Assert.IsInstanceOf(typeof(OkObjectResult), actionResponse); //Test if returns ok response  
            Assert.IsTrue(dataResult); // Test if true
            Assert.AreEqual("Unit Test Data", mockProductManager.MockFindById(_ProductList, 3).ProdSname);
        }


        /// <summary>
        /// if we not update a Product?
        /// </summary>
        [TestCase]
        public void Product_Update_InValidData()
        {
            //Arrange
            // Find a Product by id
            Product testProduct = mockProductManager.MockFindById(_ProductList, 3);

            // Change one of its properties
            testProduct.ProdSname = "Unit Test Data";

            // Auto Mapper from Product to ProductModel 
            var updateProduct = _mockMapper.Map<ProductModel>(testProduct);

            var mockProductManagerResult = new MockProductManager().MockUpdate(false, _ProductList, testProduct);
            _productController = new ProductController(
                                      mockProductManagerResult.Result.Object,
                                      _mockMapper,
                                      _mockLogger.Object);

            //ACT
            // Save our changes.
            var actionResult = _productController.Update(updateProduct);
            var actionResponse = actionResult.Result as BadRequestObjectResult;


            //Assert
            // Verify the change
            Assert.IsInstanceOf(typeof(BadRequestObjectResult), actionResponse); //Test if returns ok response  

        }

        /// <summary>
        /// Can we delete a Product?
        /// </summary>
        [TestCase]
        public void Product_Delete_Valid()
        {
            //Get Actual Count
            _ProductListCount = _ProductList.Count;

            //Arrange  
            var mockProductManagerResult = new MockProductManager().MockDelete(true, _ProductList, 4);
            _productController = new ProductController(
                                      mockProductManagerResult.Result.Object,
                                      _mockMapper,
                                      _mockLogger.Object);

            //ACT
            // Save our changes.
            var actionResult = _productController.Delete(4);
            var actionResponse = actionResult.Result as OkObjectResult;
            _mockResponse = actionResponse.Value as ApiResponse;
            var dataResult = Convert.ToBoolean(_mockResponse.ResponseObject);

            //Get Expected Count
            var expectedCount = _ProductList.Count;
            // Find a Product by id
            Product testProduct = mockProductManager.MockFindById(_ProductList, 4);

            //Assert
            // Verify the change
            Assert.IsInstanceOf(typeof(OkObjectResult), actionResponse); //Test if returns ok response  
            Assert.IsTrue(dataResult); // Test if true            
            Assert.AreEqual(expectedCount, _ProductListCount - 1); // Verify the expected Number post-delete
        }

        /// <summary>
        /// if we not delete a Product?
        /// </summary>
        [TestCase]
        public void Product_Delete_InValidId()
        {
            //Arrange  
            var mockProductManagerResult = new MockProductManager().MockDelete(false, _ProductList, 0);
            _productController = new ProductController(
                                      mockProductManagerResult.Result.Object,
                                      _mockMapper,
                                      _mockLogger.Object);
            //ACT
            // Save our changes.
            var actionResult = _productController.Delete(0);
            var actionResponse = actionResult.Result as BadRequestObjectResult;

            //Assert
            // Verify the change
            Assert.IsInstanceOf(typeof(BadRequestObjectResult), actionResponse); //Test if returns ok response            
        }
    }
}
