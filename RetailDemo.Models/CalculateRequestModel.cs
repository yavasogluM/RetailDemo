using System;
namespace RetailDemo.Models
{
    public class CalculateRequestModel
    {
        public CustomerModel Customer { get; set; }
        public InvoiceModel Invoice { get; set; }
    }
}
