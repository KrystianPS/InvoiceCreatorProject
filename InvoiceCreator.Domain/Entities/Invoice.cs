namespace InvoiceCreator.Domain.Entities
{
    public class Invoice
    {
        public string InvoiceNumber { get; set; }
        public int CompanyId { get; set; }
        public int ContractorId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public int InvoiceItemCount { get; set; }


        public List<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

        public Company Company { get; set; }
        public Contractor Contractor { get; set; }
    }
}
