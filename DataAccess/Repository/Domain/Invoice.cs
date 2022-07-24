namespace Domain.Models
{
    public class Invoice
    {
        public uint InvoiceId { get; set; }
        //public uint CustomerId { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string? BillingAddress { get; set; }
        public string? BillingCity { get; set; }
        public string? BillingState { get; set; }
        public string? BillingCountry { get; set; }
        public string? BillingPostalCode { get; set; }
        public float Total { get; set; }
    }
}
