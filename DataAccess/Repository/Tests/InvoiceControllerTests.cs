using Domain.Models;
using Infrastructure.Repositories;
using Moq;
using Repository.Controllers;
using Repository.Models;

namespace Tests
{
    [TestClass]
    public class InvoiceControllerTests
    {
        [TestMethod]
        public void CanCreateInvoiceWithCorrectModel()
        {
            // ARRANGE 
            var invoiceRepository = new Mock<IRepository<Invoice>>();
            var invoiceController = new InvoiceController(invoiceRepository.Object);

            var createInvoiceModel = new CreateInvoiceModel()
            {
                Customer = new CustomerModel()
                {
                    FirstName = "MyFirstName",
                    LastName = "MyLastName",
                    Company = "MyCompany",
                    Address = "MyAddress",
                    City = "MyCity",
                    State = "MyState",
                    Country = "MyCountry",
                    PostalCode = "MyPostalCode",
                    Phone = "MyPhone",
                    Fax = "MyFax",
                    Email = "MyEmail",
                    SupportRepId = 1
                },
                InvoiceLines = new[]
                {
                        new InvoiceLineModel(){  TrackId = 34, Quantity=10, UnitPrice = 0.87f },
                        new InvoiceLineModel(){ TrackId = 45, Quantity=20, UnitPrice = 0.89f },
                    }
            };

            // ACT
            invoiceController.CreateInvoice(createInvoiceModel);

            // ASSERT
            invoiceRepository.Verify(r => r.Add(It.IsAny<Invoice>()), Times.AtLeastOnce());
        }
    }
}

