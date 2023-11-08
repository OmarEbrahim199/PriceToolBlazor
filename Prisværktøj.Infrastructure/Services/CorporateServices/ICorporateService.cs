using pricetoolapi;

namespace Pricetool.Services
{
    public interface ICorporateService
    {

        Task<(CorporateDTO result, string message)> GetCorporateByCvrAsync(int cvr);
    }
}
