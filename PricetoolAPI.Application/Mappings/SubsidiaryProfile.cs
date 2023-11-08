using AutoMapper;
using PricetoolAPI.Application.DTOs;
using PricetoolAPI.Domain.Entities;

namespace PricetoolAPI.Application.Mappings
{
    public class SubsidiaryProfile : Profile
    {

        public SubsidiaryProfile()

        {
            CreateMap<Subsidiary, SubsidiaryDTO>().ReverseMap();

            CreateMap<Subsidiary, SubsidiaryWithProductsDTO>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products))
                .ReverseMap();
        }
    }
}