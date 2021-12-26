using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RetailDemo.Models;
using RetailDemo.Services.Customer;
using RetailDemo.Services.Invoice;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetailDemo.API.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {

        private readonly ICustomerService _customerService;
        private readonly IInvoiceService _invoiceService;

        public HomeController(ICustomerService customerService, IInvoiceService invoiceService)
        {
            _customerService = customerService;
            _invoiceService = invoiceService;
        }

        [HttpGet("calculate")]
        public async Task<string> GetCalculatedDiscount([FromBody] CalculateRequestModel request)
        {
            string result = $"test {request}";
            return result;
        }

        
    }
}
