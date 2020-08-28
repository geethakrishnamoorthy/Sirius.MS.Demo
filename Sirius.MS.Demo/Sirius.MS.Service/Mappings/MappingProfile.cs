using AutoMapper;
using Sirius.MS.BAL.Models;
using Sirius.MS.DAL.Entities;

namespace Sirius.MS.Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            //  DB Entities into View models
            CreateMap<Product, ProductModel>();
            CreateMap<GenMst, GenMstModel>();

            // View models into DB Entities            
            CreateMap<ProductModel, Product>()
                  .ForMember(dest => dest.GmidUnitNavigation, opt => opt.Ignore());
            CreateMap<GenMstModel, GenMst>();

        }
    }
}
