using System;
namespace RetailDemo.Models
{
    public class InvoiceModel : BaseModel
    {
        public decimal TotalPrice { get; set; }
        public InvoiceType Type { get; set; }
    }
}
