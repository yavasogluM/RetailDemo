using System;
namespace RetailDemo.Models
{
    public class ProductModel : BaseModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
    }
}
