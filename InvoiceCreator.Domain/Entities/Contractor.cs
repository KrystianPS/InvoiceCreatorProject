namespace InvoiceCreator.Domain.Entities
{
    public class Contractor
    {
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public string? ContractorTIN { get; set; }
        public string? Country { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
