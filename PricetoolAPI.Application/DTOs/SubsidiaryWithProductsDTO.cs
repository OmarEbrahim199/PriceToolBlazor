namespace PricetoolAPI.Application.DTOs
{
    public class SubsidiaryWithProductsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cvr { get; set; }
        public string Address { get; set; }

        public List<ProductDTO> Products { get; set; }



    }
}
