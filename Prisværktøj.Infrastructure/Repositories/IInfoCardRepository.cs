using Prisværktøj.Infrastructure.Models;

namespace Prisværktøj.Infrastructure.Repositories
{
    public interface IInfoCardRepository
    {
        IEnumerable<CardInfo> GetAllCards();
    }
}
