using Prisværktøj.Infrastructure.Models;

namespace Prisværktøj.Infrastructure.Repositories
{
    public class InfoCardRepository : IInfoCardRepository
    {
        public IEnumerable<CardInfo> GetAllCards()
        {
            return new List<CardInfo>
            {
                new CardInfo
                {
                    Date = DateTime.Now.AddDays(-2),
                    Heading = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    Information = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Link = "https://www.google.com"
                },
                new CardInfo
                {
                    Date = DateTime.Now.AddDays(-1),
                    Heading = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    Information = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Link = "https://www.google.com"
                },
                new CardInfo
                {
                    Date = DateTime.Now,
                    Heading = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    Information = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Link = "https://www.google.com"

                },
                new CardInfo
                {
                    Date = DateTime.Now.AddDays(1),
                    Heading = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    Information = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Link = "https://www.google.com"
                },
            };
        }
    }
}
