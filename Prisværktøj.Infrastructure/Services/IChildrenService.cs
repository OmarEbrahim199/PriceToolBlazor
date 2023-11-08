using Prisværktøj.Infrastructure.Models.ChildrenModel;

namespace Prisværktøj.Infrastructure.Services
{
    public interface IChildrenService
    {
        IEnumerable<Child> GetAllChildren();
        int GetTotalProducts();
    }
}