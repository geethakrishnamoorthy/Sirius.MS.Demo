using AutoMapper;
using Sirius.MS.BAL.Models;
using Sirius.MS.DAL.Entities;

namespace Sirius.MS.UnitTests.Mapper
{
    public class MockMappingProfile : Profile
    {
        public MockMappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            //  DB Entities into View models
            CreateMap<Product, ProductModel>();

            // View models into DB Entities            
            CreateMap<ProductModel, Product>()
                  .ForMember(dest => dest.GmidUnitNavigation, opt => opt.Ignore());

        }

    }
}
