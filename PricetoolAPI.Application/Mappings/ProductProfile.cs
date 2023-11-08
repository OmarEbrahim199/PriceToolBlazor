using AutoMapper;
using PricetoolAPI.Application.DTOs;
using PricetoolAPI.Domain.Entities;

namespace PricetoolAPI.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();

        }
    }
}
