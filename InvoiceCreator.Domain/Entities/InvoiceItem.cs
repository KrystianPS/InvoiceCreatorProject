namespace InvoiceCreator.Domain.Entities
{
    public class InvoiceItem
    {
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalNettAmount { get; set; }
        public decimal TotalVatAmount { get; set; }
        public decimal TotalGrossAmount { get; set; }

    }
}
