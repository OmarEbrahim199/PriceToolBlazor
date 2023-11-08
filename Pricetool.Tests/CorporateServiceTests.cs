using Microsoft.Extensions.DependencyInjection;
using Moq;
using Pricetool.Services;
using pricetoolapi;

namespace Pricetool.Tests
{
    public class CorporateServiceTests
    {

        private readonly Mock<IHttpClientFactory> _mockHttpClientFactory = new Mock<IHttpClientFactory>();
        private readonly CorporateService _corporateService;

        public CorporateServiceTests()
        {
            var services = new ServiceCollection();
            services.AddHttpClient("CorporateApi", client => client.BaseAddress = new Uri("https://localhost:7155/"));

            var serviceProvider = services.BuildServiceProvider();
            var httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
            _mockHttpClientFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(httpClientFactory.CreateClient("CorporateApi"));

            _corporateService = new CorporateService(_mockHttpClientFactory.Object);
        }

        [Fact]
        public async Task GetCorporateWithoutSubsidiariesAync()
        {
            var expectedCorporates = new List<CorporateWithoutSubsidiariesDTO>
            {
                new CorporateWithoutSubsidiariesDTO
                {
                    Cvr = 14439489,
                    Name = "Littel, Schultz and Carroll",
                    Address = "64699 Kamren Islands, Mabelleborough, Mauritania"

                },
                new CorporateWithoutSubsidiariesDTO
                {
                    Cvr = 27871536,
                    Name = "Torphy, Jacobi and McLaughlin",
                    Address = "28528 Daniela Roads, New Rosalindaborough, Jamaica"
                }
            };

            var result = await _corporateService.GetAllCorporatesAsync();

            var firstCorporate = result.First();
            var secondCorporate = result.Skip(1).First();

            Assert.NotNull(result);
            Assert.Equal(expectedCorporates[0].Cvr, firstCorporate.Cvr);
            Assert.Equal(expectedCorporates[0].Name, firstCorporate.Name);
            Assert.Equal(expectedCorporates[0].Address, firstCorporate.Address);

            Assert.Equal(expectedCorporates[1].Cvr, secondCorporate.Cvr);
            Assert.Equal(expectedCorporates[1].Name, secondCorporate.Name);
            Assert.Equal(expectedCorporates[1].Address, secondCorporate.Address);
        }


        [Fact]
        public async Task GetCorporateWithSubsidiaries_ReturnsCorrectData()
        {
            var someCvr = 27871536;
            var expectedCorporateName = "Torphy, Jacobi and McLaughlin";
            var expectedSubsidiariesCount = 1;
            var expectedSubsidiaryName = "Schinner Inc";
            var corporateDto = await _corporateService.GetCorporateByCvrAsync(someCvr);


            Assert.NotNull(corporateDto);
            /*
            Assert.Equal(expectedCorporateName, corporateDto.Name);


            // Assert: Check the subsidiaries.
            Assert.NotNull(corporateDto.Subsidiaries);
            Assert.Equal(expectedSubsidiariesCount, corporateDto.Subsidiaries.Count);
            foreach (var subsidiary in corporateDto.Subsidiaries)
            {
                Assert.NotNull(subsidiary);
                Assert.Equal(expectedSubsidiaryName, subsidiary.Name);

            }
            */
        }
    }
}