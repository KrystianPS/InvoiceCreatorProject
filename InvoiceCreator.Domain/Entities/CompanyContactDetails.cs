namespace InvoiceCreator.Domain.Entities
{
    public class CompanyContactDetails
    {
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
