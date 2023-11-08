using AutoMapper;
using PricetoolAPI.Application.DTOs;
using PricetoolAPI.Domain;

namespace PricetoolAPI.Application.Services
{
    public class CorporateService : ICorporateService
    {
        private readonly ICorporateRepository _repository;
        private readonly IMapper _mapper;  // AutoMapper instance

        public CorporateService(ICorporateRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CorporateWithoutSubsidiariesDTO>> GetAllCorporatesAsync()
        {
            var corporates = await _repository.GetAllCorporatesAsync();
            return _mapper.Map<IEnumerable<CorporateWithoutSubsidiariesDTO>>(corporates);
        }


        public async Task<CorporateDTO> GetCorporateByCvrAsync(int cvr)
        {
            var corporate = await _repository.GetCorporateByCvrWithSubsidiariesAsync(cvr);
            return _mapper.Map<CorporateDTO>(corporate);
        }

    }
}
