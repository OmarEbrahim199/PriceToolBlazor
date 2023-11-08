using AutoMapper;
using PricetoolAPI.Application.DTOs;
using PricetoolAPI.Domain;

namespace PricetoolAPI.Application.Services
{
    public class SubsidiaryService : ISubsidiaryService
    {

        private readonly ISubsidiaryRepository _subsidiaryRepository;
        private readonly IMapper _mapper;

        public SubsidiaryService(ISubsidiaryRepository subsidiaryRepository, IMapper mapper)
        {
            _subsidiaryRepository = subsidiaryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SubsidiaryDTO>> GetAllSubsidiariesAsync()
        {
            var subsidiaries = await _subsidiaryRepository.GetAllSubsidiariesAsync();
            return _mapper.Map<IEnumerable<SubsidiaryDTO>>(subsidiaries);
        }

        public async Task<SubsidiaryDTO?> GetSubsidiaryByCvrAsync(int cvr)
        {
            var subsidiary = await _subsidiaryRepository.GetSubsidiaryByCvrAsync(cvr);
            return _mapper.Map<SubsidiaryDTO>(subsidiary);
        }

        public async Task<SubsidiaryWithProductsDTO?> GetSubsidiaryWithProductsByCvrAsync(int cvr)
        {
            var subsidiary = await _subsidiaryRepository.GetSubsidiaryWithProductsByCvrAsync(cvr);
            return _mapper.Map<SubsidiaryWithProductsDTO>(subsidiary);
        }


    }
}