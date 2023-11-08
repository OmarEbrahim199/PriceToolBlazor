using AutoMapper;
using PricetoolAPI.Application.DTOs;
using PricetoolAPI.Domain;

namespace PricetoolAPI.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;  // AutoMapper instance

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var products = await _repository.GetAllProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);

        }

    }

}