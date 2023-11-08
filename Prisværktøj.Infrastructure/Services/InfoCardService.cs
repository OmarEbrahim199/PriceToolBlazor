using Prisværktøj.Infrastructure.Models;
using Prisværktøj.Infrastructure.Repositories;

namespace Prisværktøj.Infrastructure.Services
{
    public class InfoCardService : IInfoCardService
    {
        private readonly IInfoCardRepository _infoCardRepository;

        public InfoCardService(IInfoCardRepository infoCardRepository)
        {
            _infoCardRepository = infoCardRepository;
        }

        public IEnumerable<CardInfo> GetAllCards()
        {
            return _infoCardRepository.GetAllCards();
        }
    }
}
