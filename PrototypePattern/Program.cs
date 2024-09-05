

using PrototypePattern.Models;

Invoice invoice = new Invoice
{
    InvoiceNumber = "INV-001",
    InvoiceDate = DateTime.Now,
    Balance = 1000,
    Tax = 100,
    Country = "USA"
};

Invoice clonedInvoice = (Invoice)invoice.Clone();
clonedInvoice.InvoiceNumber = "INV-002";

Console.ReadLine();
