namespace InvoiceCreator.Domain.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public int Companyid { get; set; }
        public string? Description { get; set; }
        public decimal UnitNettAmount { get; set; }
        public decimal VatRate { get; set; }
        public decimal UnitGrossAmount { get; set; }
    }
}
