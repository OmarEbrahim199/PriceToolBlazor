using Prisværktøj.Infrastructure.Models.ChildrenModel;

using Prisværktøj.Infrastructure.Repositories;

namespace Prisværktøj.Infrastructure.Services
{
    public class ChildrenService : IChildrenService
    {
        private readonly IChildrenRepository _childrenRepository;

        public ChildrenService(IChildrenRepository childrenRepository)
        {
            _childrenRepository = childrenRepository;
        }

        public IEnumerable<Child> GetAllChildren()
        {
            // Here you can add any business logic, orchestrate multiple repo calls, etc.
            return _childrenRepository.GetAllChildren();
        }

        public int GetTotalProducts()
        {
            return _childrenRepository.GetAllChildren().Sum(child => child.NumberOfProducts);
        }

    }
}
