using Prisværktøj.Infrastructure.Models.ChildrenModel;

namespace Prisværktøj.Infrastructure.Repositories
{
    public class ChildrenRepository : IChildrenRepository
    {
        public IEnumerable<Child> GetAllChildren()
        {
            return new List<Child>
           {
                new Child
                {
                    Title = "Axel Pitzner Fonden",
                    Amount = 10000000,
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "AM",
                            Amount = 100
                        },
                        new Product
                        {
                            Name = "Indlån",
                            Amount = 20000000
                        },

                        new Product
                        {
                            Name = "Rådgivning",
                            Amount = 30000000
                        },

                        new Product
                        {
                            Name = "Kassekredit",
                            Amount = 40000000
                        },

                        new Product
                        {
                            Name = "Lønkonto",
                            Amount = 50000000
                        },

                        new Product
                        {
                            Name = "Kort",
                            Amount = 60000000
                        },
                    }
                },
                new Child
                {
                    Title = "ROOM95 ApS",
                    Amount = 200,
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Ingen aftale",
                            Amount = 300
                        },
                        new Product
                        {
                            Name = "Rådgivning",
                            Amount = 400
                        }
                    }
                },

                new Child
                {
                    Title = "Pan X ApS",
                    Amount = 300,
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Ingen aftale",
                            Amount = 300
                        },
                        new Product
                        {
                            Name = "Rådgivning",
                            Amount = 400
                        }
                    }
                },

                new Child
                {
                    Title = "Jacob Eberhard Invest ApS",
                    Amount = 400,
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Ingen aftale",
                            Amount = 300
                        },
                        new Product
                        {
                            Name = "Rådgivning",
                            Amount = 400
                        }
                    }
                },

                new Child
                {
                    Title = "Aperon Apartment Hotel ApS",
                    Amount = 500,
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Ingen aftale",
                            Amount = 300
                        },
                        new Product
                        {
                            Name = "Rådgivning",
                            Amount = 400
                        }
                    }
                },

                new Child
                {
                    Title = "Pitzner Gruppen HOlding A/S",
                    Amount = 600,
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Ingen aftale",
                            Amount = 300
                        },
                        new Product
                        {
                            Name = "Rådgivning",
                            Amount = 400
                        }
                    }
                },
            };
        }
    }
}
