using pricetoolapi;

namespace Pricetool.Services
{
    public class SubsidiaryService
    {
        private readonly ClientReference _apiClient;

        public SubsidiaryService(IHttpClientFactory clientFactory)
        {
            var httpClient = clientFactory.CreateClient("SubsidiaryApi");
            _apiClient = new ClientReference(httpClient.BaseAddress?.ToString(), httpClient);
        }

        public async Task<SubsidiaryWithProductsDTO> GetSubsidiaryWithProdcutsByCvrAsync(int cvr)
        {
            return await _apiClient.ProductsAsync(cvr);
        }

    }
}
