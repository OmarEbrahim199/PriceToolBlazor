using Bogus;
using Microsoft.EntityFrameworkCore;
using PricetoolAPI.Domain.Entities;

namespace PricetoolAPI.DataAccess
{
    public class DataContext : DbContext

    {
        public DbSet<Corporate> Corporates { get; set; }

        public DbSet<Subsidiary> Subsidiary { get; set; }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureCorporate(modelBuilder);
            ConfigureSubsidiary(modelBuilder);
            SeedData(modelBuilder);
        }

        private void ConfigureCorporate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corporate>()
                .Property(c => c.Cvr)
                .ValueGeneratedNever();
        }

        private void ConfigureSubsidiary(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subsidiary>()
                .Property(s => s.Cvr)
                .ValueGeneratedNever();
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var corporates = GenerateFakeCorporates();
            modelBuilder.Entity<Corporate>().HasData(corporates);

            var subsidiaries = GenerateFakeSubsidiaries(corporates);
            modelBuilder.Entity<Subsidiary>().HasData(subsidiaries);

            var product = GenerateFakeProducts(subsidiaries);
            modelBuilder.Entity<Product>().HasData(product);
        }

        private List<Corporate> GenerateFakeCorporates()
        {
            var faker = new Faker<Corporate>()
                .RuleFor(c => c.Cvr, f => f.Random.Int(10000000, 99999999)) // Generates a random 8-digit number
                .RuleFor(c => c.Name, f => f.Company.CompanyName())
                .RuleFor(c => c.Address, f => f.Address.FullAddress());

            return faker.Generate(10); // Generates 10 fake corporates
        }

        private List<Subsidiary> GenerateFakeSubsidiaries(List<Corporate> corporates)
        {
            var faker = new Faker<Subsidiary>()
                .RuleFor(s => s.Cvr, f => f.Random.Int(10000000, 99999999)) // Generates a random 8-digit number
                .RuleFor(s => s.Name, f => f.Company.CompanyName())
                .RuleFor(s => s.Address, f => f.Address.FullAddress())
                .RuleFor(s => s.ParentCorporateCvr, f => f.PickRandom(corporates).Cvr);

            return faker.Generate(10); // Generates 10 fake subsidiaries
        }

        private List<Product> GenerateFakeProducts(List<Subsidiary> subsidiaries)
        {
            var faker = new Faker<Product>()
                .RuleFor(p => p.Id, f => f.UniqueIndex) // This will generate unique Id values starting from 0
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Type, f => f.Commerce.ProductAdjective())
                .RuleFor(p => p.Principal, f => f.Random.Decimal(0, 10000))
                .RuleFor(p => p.SubsidiaryCvr, f => f.PickRandom(subsidiaries).Cvr);

            return faker.Generate(20); // Generates 20 fake products
        }



        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }




    }
}
