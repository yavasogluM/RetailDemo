using System;
using System.Collections.Generic;
using RetailDemo.Models;

namespace RetailDemo.Services.Invoice
{
    public interface IInvoiceService
    {
        decimal CalculateDiscount(CustomerModel customer, InvoiceModel invoice);
    }
}
