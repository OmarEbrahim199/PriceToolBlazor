namespace Prisværktøj.Infrastructure.Models.ChildrenModel
{
    public class Child
    {
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public List<Product> Products { get; set; }
        public int NumberOfProducts => Products?.Count ?? 0;
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }


        // ... any other properties related to Product
    }
}
