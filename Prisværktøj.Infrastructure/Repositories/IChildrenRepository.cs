using Prisværktøj.Infrastructure.Models.ChildrenModel;

namespace Prisværktøj.Infrastructure.Repositories
{
    public interface IChildrenRepository
    {
        IEnumerable<Child> GetAllChildren();
    }
}