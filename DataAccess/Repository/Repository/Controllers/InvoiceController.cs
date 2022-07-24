using Domain.Models;
using Infrastructure.Repositories;
using Repository.Models;

namespace Repository.Controllers
{
    public class InvoiceController
    {
        private readonly IRepository<Invoice> _invoiceRepository;

        public InvoiceController(IRepository<Invoice> invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public IEnumerable<Invoice>? FindInvoicesPerYear(int year)
        {
            IEnumerable<Invoice>? invoices = _invoiceRepository.Find(invoice => invoice.InvoiceDate.Year == year);
            return invoices;
        }

        public Invoice? GetLatestInvoice()
        {
            return _invoiceRepository.All().OrderByDescending(i => i.InvoiceId).FirstOrDefault();
        }

        public void UpdateInvoice(Invoice invoice)
        {
             _invoiceRepository.Update(invoice);
            _invoiceRepository.SaveChanges();
        }

        public void CreateInvoice(CreateInvoiceModel model)
        {
            if (!model.InvoiceLines.Any()) throw new InvalidOperationException("Please submit line items");

            if (string.IsNullOrWhiteSpace(model.Customer.FirstName) ||
                string.IsNullOrWhiteSpace(model.Customer.LastName)) 
                throw new InvalidOperationException("Customer needs a FirstName and a LastName");

            var customer = new Customer
            {
                FirstName = model.Customer.FirstName,
                LastName= model.Customer.LastName,
                Company = model.Customer.Company,
                Address = model.Customer.Address,
                City = model.Customer.City,
                State = model.Customer.State,
                Country = model.Customer.Country,
                PostalCode = model.Customer.PostalCode,
                Phone = model.Customer.Phone,
                Fax = model.Customer.Fax,
                Email = model.Customer.Email,
                SupportRepId = model.Customer.SupportRepId
            };

            var invoice = new Invoice
            {
                InvoiceLines = model.InvoiceLines
                    .Select(line => new InvoiceLine { TrackId = line.TrackId, Quantity = line.Quantity, UnitPrice = line.UnitPrice })
                    .ToList(),
                Customer = customer,
                InvoiceDate = DateTime.Now
            };

            _invoiceRepository.Add(invoice);

            _invoiceRepository.SaveChanges();
        }

    }
}
