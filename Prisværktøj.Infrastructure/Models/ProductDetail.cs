namespace Prisværktøj.Infrastructure.Models
{
    public class ProductDetail
    {
        public string Produkt { get; set; }
        public string Kunde { get; set; }
        public decimal HovedstolMax { get; set; }
        public string Engagement { get; set; }
        public DateTime SenesteBeregning { get; set; }
        public string TilføjetAf { get; set; }
        public string Påvirker { get; set; }

        public string Ret { get; set; }

    }
}