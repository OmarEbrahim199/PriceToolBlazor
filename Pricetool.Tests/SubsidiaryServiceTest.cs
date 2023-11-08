using Microsoft.Extensions.DependencyInjection;
using Moq;
using Pricetool.Services;
using pricetoolapi;

namespace Pricetool.Tests
{
    public class SubsidiaryServiceTest
    {

        private readonly Mock<IHttpClientFactory> _mockHttpClientFactory = new Mock<IHttpClientFactory>();
        private readonly SubsidiaryService _subsidiaryService;
        public SubsidiaryServiceTest()
        {
            var services = new ServiceCollection();
            services.AddHttpClient("CorporateApi", client => client.BaseAddress = new Uri("https://localhost:7155/"));

            var serviceProvider = services.BuildServiceProvider();
            var httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
            _mockHttpClientFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(httpClientFactory.CreateClient("CorporateApi"));

            _subsidiaryService = new SubsidiaryService(_mockHttpClientFactory.Object);
        }

        [Fact]

        public async Task GetSubsidiariesWithProducts_ReturnCorrectData()
        {
            var subsidiaryCvr = 17074996;
            var actualSubsidiary = await _subsidiaryService.GetSubsidiaryWithProdcutsByCvrAsync(subsidiaryCvr);


            var expectedSubsidiary = new SubsidiaryWithProductsDTO

            {
                Cvr = 17074996,
                Name = "Brekke, Blanda and Wilderman",
                Address = "736 Alejandrin Glen, Cassinville, Mauritius",
                Products = new List<ProductDTO>
                {
                new ProductDTO { Name = "Sleek Plastic Salad", Type = "Fantastic" }
                }
            };



            Assert.NotNull(actualSubsidiary);
            Assert.Equal(expectedSubsidiary.Cvr, actualSubsidiary.Cvr);
            Assert.Equal(expectedSubsidiary.Name, actualSubsidiary.Name);
            Assert.Equal(expectedSubsidiary.Address, actualSubsidiary.Address);

            foreach (var actualProduct in actualSubsidiary.Products)
            {
                var matchingProduct = expectedSubsidiary.Products.FirstOrDefault(p => p.Name == actualProduct.Name && p.Type == actualProduct.Type);
                Assert.NotNull(matchingProduct); // This will fail if the product was not found in the expected products list
            }
        }

    }

}
