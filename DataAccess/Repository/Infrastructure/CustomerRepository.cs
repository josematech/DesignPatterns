using Domain.Models;

namespace Infrastructure.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>
    {
        public CustomerRepository(ChinookContext context) : base(context)
        {

        }
        public override Customer Update(Customer entity)
        {
            var customer = context.Customer
                .Single(c => c.CustomerId == entity.CustomerId);

            customer.FirstName = entity.FirstName;
            customer.LastName = entity.LastName;
            customer.Company = entity.Company;
            customer.Address = entity.Address;
            customer.City = entity.City;
            customer.State = entity.State;
            customer.Country = entity.Country;
            customer.PostalCode = entity.PostalCode;
            customer.Phone = entity.Phone;
            customer.Fax = entity.Phone;
            customer.Email = entity.Email;
            customer.SupportRepId = entity.SupportRepId;

            return base.Update(customer);
        }
    }
}