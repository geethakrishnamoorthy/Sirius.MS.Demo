using System.Threading.Tasks;
using Sirius.MS.DAL.Entities;

namespace Sirius.MS.DAL.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetProductByCode(string code);
    }
}
