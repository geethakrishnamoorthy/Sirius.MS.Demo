using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sirius.MS.BAL.Managers.Interfaces;
using Sirius.MS.DAL.Entities;
using Sirius.MS.DAL.Repositories;
using Sirius.MS.DAL.Repositories.Interfaces;

namespace Sirius.MS.BAL.Managers
{
    public class ProductManager : GenericManager<Product>, IProductManager
    {
        private readonly IProductRepository _productRepository;
        public ProductManager()
        {
            _productRepository = new ProductRepository();
        }

        public override async Task<Product> Load(long id)
        {
            Product _product;
            try
            {
                _product = await _productRepository.Load(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(_product);
        }        

        public async Task<Product> GetProductByCode(string code)
        {
            Product _product;
            try
            {
                _product = await _productRepository.GetProductByCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(_product);
        }
        public override async Task<long> Create(Product _product)
        {
            long id;
            try
            {
                id = await _productRepository.Create(_product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(id);
        }

    }
}
