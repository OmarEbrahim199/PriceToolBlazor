using Prisværktøj.Infrastructure.Models;

namespace Prisværktøj.Infrastructure.Services
{
    public interface IInfoCardService
    {
        IEnumerable<CardInfo> GetAllCards();
    }
}
