namespace Repository.Models
{
    public class CreateInvoiceModel
    {
        public IEnumerable<InvoiceLineModel> InvoiceLines { get; set; }
        public CustomerModel Customer { get; set; }
    }
}

