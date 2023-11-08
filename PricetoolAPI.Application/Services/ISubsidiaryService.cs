using PricetoolAPI.Application.DTOs;

namespace PricetoolAPI.Application.Services
{
    public interface ISubsidiaryService
    {
        Task<IEnumerable<SubsidiaryDTO>> GetAllSubsidiariesAsync();

        Task<SubsidiaryDTO?> GetSubsidiaryByCvrAsync(int cvr);

        Task<SubsidiaryWithProductsDTO?> GetSubsidiaryWithProductsByCvrAsync(int cvr);
    }
}
