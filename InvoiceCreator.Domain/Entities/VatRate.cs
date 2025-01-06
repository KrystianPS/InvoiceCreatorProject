namespace InvoiceCreator.Domain.Entities
{
    public class VatRate
    {
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public string Description { get; set; }
    }
}
