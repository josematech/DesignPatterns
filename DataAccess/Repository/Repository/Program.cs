using Domain.Models;
using Infrastructure;
using Infrastructure.Repositories;
using System.Configuration;
using Repository.Controllers;
using Repository.Models;

namespace Repository
{
    internal class Program
    {
        private static string? connectionString;

        static void Main(string[] args)
        {
            Console.WriteLine("Repository pattern demo!");

            connectionString = ConfigurationManager.AppSettings["CnString"];

            using (ChinookContext? context = new ChinookContext(connectionString))
            {
                //// To Delete Existing Database if it exists
                //context.Database.EnsureDeleted();
                //// To Create a new database if it does not exist
                //context.Database.EnsureCreated();

                IRepository<Artist> artistRepository = new ArtistRepository(context);
                IRepository<Customer> customerRepository = new CustomerRepository(context);
                IRepository<Invoice> invoiceRepository = new InvoiceRepository(context);

                /*artistRepository.Add(new Artist { Name = "Pete" });
                artistRepository.Add(new Artist { Name = "Michael" });
                artistRepository.SaveChanges();*/

                var allArtists = artistRepository.All();
                var allCustomers = customerRepository.All();
                var allInvoices = invoiceRepository.All();

                InvoiceController myInvoiceController = new InvoiceController(invoiceRepository);
                var invoices = myInvoiceController.FindInvoicesPerYear(2010);

                var createInvoiceModel = new CreateInvoiceModel()
                {
                    Customer = new CustomerModel()
                    {
                        FirstName = "MyFirstName",
                        LastName= "MyLastName",
                        Company= "MyCompany",
                        Address= "MyAddress",
                        City= "MyCity",
                        State= "MyState",
                        Country= "MyCountry",
                        PostalCode= "MyPostalCode",
                        Phone= "MyPhone",
                        Fax= "MyFax",
                        Email= "MyEmail",
                        SupportRepId= 1
                     },
                    InvoiceLines = new[]
                    {
                        new InvoiceLineModel(){  TrackId = 34, Quantity=10, UnitPrice = 0.87f },
                        new InvoiceLineModel(){ TrackId = 45, Quantity=20, UnitPrice = 0.89f },
                    }
                };

                myInvoiceController.CreateInvoice(createInvoiceModel);

                var myInvoice = myInvoiceController.GetLatestInvoice();
                if (myInvoice != null)
                {
                    myInvoice.BillingAddress = "MyBillingAddress";
                    myInvoice.BillingCity = "MyBillingCity";
                    myInvoice.BillingCountry = "MyBillingCountry";
                    myInvoice.BillingPostalCode = "MyBillingPostalCode";
                    myInvoiceController.UpdateInvoice(myInvoice);
                }
            }

            Console.ReadKey();

        }

    }
}