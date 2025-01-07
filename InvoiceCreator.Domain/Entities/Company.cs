namespace InvoiceCreator.Domain.Entities
{
    public class Company
    {
        public string Name { get; set; }
        public string CompanyTIN { get; set; }

        public CompanyAddressDetails AddressDetails { get; set; }

        public CompanyContactDetails ContactDetails { get; set; }


        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
        public List<Contractor> Contractors { get; set; } = new List<Contractor>();


    }
}
