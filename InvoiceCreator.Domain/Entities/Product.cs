namespace InvoiceCreator.Domain.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public string? Description { get; set; }
        public decimal UnitNettAmount { get; set; }
        public VatRate VatRate { get; set; } = default!;
        public decimal UnitGrossAmount { get; set; }
    }
}
