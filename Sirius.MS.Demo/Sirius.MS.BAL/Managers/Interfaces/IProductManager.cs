using System.Threading.Tasks;
using Sirius.MS.DAL.Entities;

namespace Sirius.MS.BAL.Managers.Interfaces
{
    public interface IProductManager : IManager<Product>
    {
        Task<Product> GetProductByCode(string code);
    }   
}
