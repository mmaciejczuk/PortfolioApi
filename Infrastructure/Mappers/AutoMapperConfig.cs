using AutoMapper;
using WebApplication.Core.Domain;
using WebApplication.Infrastructure.DTO;

namespace WebApplication.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Portfolio, PortfolioDTO>();
            })
            .CreateMapper();
    }
}
