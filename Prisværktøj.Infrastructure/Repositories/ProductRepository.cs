using Prisværktøj.Infrastructure.Models;

namespace Prisværktøj.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<ProductDetail> GetAllProductDetails()
        {
            return new List<ProductDetail>
    {
        new ProductDetail
        {
            Produkt = "Produkt A",
            Kunde = "Kunde A",
            HovedstolMax = 1000.50M,
            Engagement = "Engagement A",
            SenesteBeregning = DateTime.Now.AddDays(-1),
            TilføjetAf = "User A",
            Påvirker = "Påvirker A",
            Ret = "Ret A"
        },
        new ProductDetail
        {
            Produkt = "Produkt B",
            Kunde = "Kunde B",
            HovedstolMax = 2000.75M,
            Engagement = "Engagement B",
            SenesteBeregning = DateTime.Now.AddDays(-2),
            TilføjetAf = "User B",
            Påvirker = "Påvirker B",
            Ret = "Ret B"
        },
        new ProductDetail
        {
            Produkt = "Produkt C",
            Kunde = "Kunde C",
            HovedstolMax = 3000.25M,
            Engagement = "Engagement C",
            SenesteBeregning = DateTime.Now.AddDays(-3),
            TilføjetAf = "User C",
            Påvirker = "Påvirker C",
            Ret = "Ret C"

        },

        new ProductDetail
        {
            Produkt = "Produkt D",
            Kunde = "Kunde D",
            HovedstolMax = 4000.25M,
            Engagement = "Engagement D",
            SenesteBeregning = DateTime.Now.AddDays(-4),
            TilføjetAf = "User D",
            Påvirker = "Påvirker D",
            Ret = "Ret D"

        },
        new ProductDetail
        {
            Produkt = "Produkt E",
            Kunde = "Kunde E",
            HovedstolMax = 5000.25M,
            Engagement = "Engagement E",
            SenesteBeregning = DateTime.Now.AddDays(-5),
            TilføjetAf = "User E",
            Påvirker = "Påvirker E",
            Ret = "Ret E"


        }

            };
        }
    }
}

