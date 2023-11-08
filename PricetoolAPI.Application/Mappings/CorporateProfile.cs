using AutoMapper;
using PricetoolAPI.Application.DTOs;
using PricetoolAPI.Domain.Entities;

namespace PricetoolAPI.Application.Mappings
{
    public class CorporateProfile : Profile
    {
        public CorporateProfile()
        {
            CreateMap<Corporate, CorporateDTO>()
                .ForMember(dest => dest.Subsidiaries, opt => opt.MapFrom(src => src.Subsidiaries))
                .ReverseMap();

            CreateMap<Corporate, CorporateWithoutSubsidiariesDTO>().ReverseMap();
        }
    }
}
