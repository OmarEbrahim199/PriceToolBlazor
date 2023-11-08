using pricetoolapi;

namespace Pricetool.Services
{
    public class CorporateService : ICorporateService
    {
        private readonly ClientReference _apiClient;

        public CorporateService(IHttpClientFactory clientFactory)
        {
            var httpClient = clientFactory.CreateClient("CorporateApi");
            _apiClient = new ClientReference(httpClient.BaseAddress?.ToString(), httpClient);
        }

        public async Task<(CorporateDTO result, string message)> GetCorporateByCvrAsync(int cvr)
        {
            try
            {
                CorporateDTO result = await _apiClient.CorporateAsync(cvr);
                return (result, "Corporate data retrieved successfully.");
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode == 500)
                {
                    return (null, "No corporate found with CVR: '" + cvr + "'");

                }
                return (null, "Status Code" + ex.StatusCode);

            }
            catch (Exception ex)
            {
                return (null, "Error: " + ex.Message);
            }

        }

        public async Task<IEnumerable<CorporateWithoutSubsidiariesDTO>> GetAllCorporatesAsync()
        {
            return await _apiClient.CorporateAllAsync();
        }



    }
}
