using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Sirius.MS.DAL.Entities;
using Sirius.MS.DAL.Repositories.Interfaces;

namespace Sirius.MS.DAL.Repositories
{

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public override async Task<Product> Load(long id)
        {
            Product _product = new Product();
            try
            {
                _product = Db.Product
                              .Where(x => x.Id == id && x.ActiveStatus == "A" && x.DeleteStatus == "A")
                              .Include(x => x.GmidUnitNavigation)
                              .FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(_product);
        }

       
        public async Task<Product> GetProductByCode(string code)
        {
            Product _product = new Product();
            try
            {
                _product = Db.Product
                              .Where(x => x.ProdCode.ToLower() == code.ToLower() && x.ActiveStatus == "A" && x.DeleteStatus == "A")
                              .Include(x => x.GmidUnitNavigation)
                              .FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(_product);
        }

        public override async Task<long> Create(Product _product)
        {
            try
            {
                Db.Set<Product>().Add(_product);
                Db.SaveChanges();
                resultStatus = true;
                return await Task.FromResult(_product.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
    }
}
