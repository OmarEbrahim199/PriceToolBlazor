namespace PricetoolAPI.Application.DTOs
{
    public class CorporateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cvr { get; set; }
        public string Address { get; set; }

        public List<SubsidiaryDTO> Subsidiaries { get; set; } = new List<SubsidiaryDTO>();
    }
}
