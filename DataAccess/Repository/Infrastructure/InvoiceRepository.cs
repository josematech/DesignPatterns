using Domain.Models;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure
{
    public class InvoiceRepository : GenericRepository<Invoice>
    {
        public InvoiceRepository(ChinookContext context) : base(context)
        {

        }
        public override IEnumerable<Invoice> Find(Expression<Func<Invoice, bool>> predicate)
        {
            return context.Invoice
                .Include(invoice => invoice.InvoiceLines)
                .ThenInclude(lineItem => lineItem.Track)
                .Where(predicate).ToList();
        }

        public override Invoice Update(Invoice entity)
        {
            var invoice = context.Invoice
                .Include(o => o.InvoiceLines)
                .ThenInclude(lineItem => lineItem.Track)
                .Single(e => e.InvoiceId == entity.InvoiceId);

            invoice.InvoiceDate  = entity.InvoiceDate;
            invoice.InvoiceLines = entity.InvoiceLines;

            return base.Update(invoice);
        }

    }
}
