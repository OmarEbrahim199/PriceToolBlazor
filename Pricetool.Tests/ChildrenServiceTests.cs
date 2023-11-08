namespace Pricetool.Tests
{
    using Moq;
    using Prisværktøj.Infrastructure.Models.ChildrenModel;
    using Prisværktøj.Infrastructure.Repositories;
    using Prisværktøj.Infrastructure.Services;

    public class ChildrenServiceTests
    {
        [Fact]
        public void GetAllChildren_ReturnsAllChildren()
        {
            // Arrange
            var mockRepo = new Mock<IChildrenRepository>();
            var childrenList = new List<Child>
        {
            new Child {
                Title = "Child1",
                Amount = 100M,
                Products = new List<Product> { new Product { Name = "Prod1", Amount = 50M } } },
            new Child {
                Title = "Child2",
                Amount = 200M,
                Products = new List<Product>
                {
                new Product { Name = "Prod2", Amount = 60M },
                new Product { Name = "Prod3", Amount = 70M }
                }
            }
        };
            mockRepo.Setup(repo => repo.GetAllChildren()).Returns(childrenList);
            var service = new ChildrenService(mockRepo.Object);

            // Act
            var result = service.GetAllChildren();

            // Assert
            Assert.Equal(childrenList, result);
        }

        [Fact]
        public void GetTotalProducts_ReturnsTotalProducts()
        {
            // Arrange
            var mockRepo = new Mock<IChildrenRepository>();
            var childrenList = new List<Child>
        {
            new Child {
                Title = "Child1",
                Amount = 100M,
                Products = new List<Product> {
                    new Product { Name = "Prod1", Amount = 50M } } },

            new Child {
                Title = "Child2",
                Amount = 200M,
                Products = new List<Product> {
                    new Product { Name = "Prod2", Amount = 60M },
                    new Product { Name = "Prod3", Amount = 70M }
                }
            }
        };
            mockRepo.Setup(repo => repo.GetAllChildren()).Returns(childrenList);
            var service = new ChildrenService(mockRepo.Object);

            // Act
            var totalProducts = service.GetTotalProducts();

            // Assert
            Assert.Equal(3, totalProducts); // 1 + 2 = 3 products in total
        }
    }
}