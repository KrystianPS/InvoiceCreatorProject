namespace InvoiceCreator.Domain.Entities
{
    public class Contractor
    {
        public required int Id { get; set; }
        public Company Company { get; set; } = default!;
        public int CompanyId { get; set; }
        public string ContractorName { get; set; } = default!;
        public string? ContractorTIN { get; set; }
        public ContractorAddressDetails AdressDetails { get; set; } = default!;
        public ContractorContactDetails ContactDetails { get; set; } = default!;
        public string Notes { get; set; }

        public string EncodedName { get; private set; } = default!;



        public void EncodeName() => EncodedName = ContractorName.ToLower().Replace(" ", "-");
    }
}
