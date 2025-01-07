namespace InvoiceCreator.Domain.Entities
{
    public class ContractorContactDetails
    {
        public Contractor Contractor { get; set; }
        public int ContractorId { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
