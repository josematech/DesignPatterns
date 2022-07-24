namespace Domain.Models
{
    public class InvoiceLine
    {
        public uint InvoiceLineId { get; set; }
        public uint InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public uint TrackId { get; set; }
        public Track Track { get; set; }
        public float UnitPrice { get; set; }
        public uint Quantity { get; set; }
    }
}