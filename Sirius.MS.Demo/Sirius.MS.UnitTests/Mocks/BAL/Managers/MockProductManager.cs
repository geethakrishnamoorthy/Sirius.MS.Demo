using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sirius.MS.BAL.Managers.Interfaces;
using Sirius.MS.DAL.Entities;

namespace Sirius.MS.UnitTests.Mocks.BAL.Managers
{
    public class MockProductManager : Mock<IProductManager>
    {
        public async Task<MockProductManager> MockLoad(Product result)
        {
            Setup(x => x.Load(It.IsAny<long>()))
                .Returns(Task.Run(() => result));
            return await Task.FromResult(this);
        }

        public async Task<MockProductManager> MockLoadList(IList<Product> result)
        {
            if (result != null)
            {
                Setup(x => x.LoadList()).Returns(Task.Run(() => new List<Product>(result)));
            }
            else
            {
                Setup(x => x.LoadList()).Returns(Task.Run(() => new List<Product>()));
            }

            return await Task.FromResult(this);
        }

        public async Task<MockProductManager> MockCreate(long result, IList<Product> objList, Product objCreate)
        {
            // Allows us to test saving a product
            Setup(x => x.Create(It.IsAny<Product>())).Returns(Task.Run(() => result));
            if (objCreate != null && result > 0)
            {
                objList.Add(objCreate);
            }
            return await Task.FromResult(this);
        }
        public async Task<MockProductManager> MockUpdate(bool result, IList<Product> objList, Product objUpdate)
        {
            // Allows us to test saving a product
            Setup(x => x.Update(It.IsAny<Product>())).Returns(Task.Run(() => result));
            if (objUpdate != null && result)
            {
                var objDelete = objList.Where(x => x.Id == objUpdate.Id).FirstOrDefault();
                objList.Remove(objDelete);
                objList.Add(objUpdate);
            }
            return await Task.FromResult(this);
        }

        public async Task<MockProductManager> MockDelete(bool result, IList<Product> objList, long id)
        {
            Setup(x => x.Delete(It.IsAny<long>())).Returns(Task.Run(() => result));
            if (id > 0 && result)
            {
                var objDelete = objList.Where(x => x.Id == id).FirstOrDefault();
                objList.Remove(objDelete);
            }
            return await Task.FromResult(this); ;
        }
        public async Task<MockProductManager> MockGetProductByCode(Product result, IList<Product> objList, string code)
        {
            Setup(x => x.GetProductByCode(It.IsAny<string>())).Returns(Task.Run(() => result));
            return await Task.FromResult(this);
        }

        public Product MockFindById(IList<Product> ProductModels, int id)
        {
            var result = ProductModels.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }
        public Product MockFindByName(List<Product> ProductModels, string name)
        {
            var result = ProductModels.Where(x => x.ProdSname == name).SingleOrDefault();
            return result;
        }
        public Product MockFindByCode(IList<Product> ProductModels, string code)
        {
            var result = ProductModels.Where(x => x.ProdCode == code).SingleOrDefault();
            return result;
        }
    }
}
