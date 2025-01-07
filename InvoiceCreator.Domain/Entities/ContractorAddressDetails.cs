namespace InvoiceCreator.Domain.Entities
{
    public class ContractorAddressDetails
    {
        public Contractor Contractor { get; set; }
        public int ContractorId { get; set; }
        public string Country { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

    }
}
