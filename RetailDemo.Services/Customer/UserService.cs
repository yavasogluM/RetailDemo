using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RetailDemo.Models;

namespace RetailDemo.Services.Customer
{
    public class CustomerService : Base.BaseService<Models.CustomerModel>, ICustomerService
    {
        public async Task<CustomerModel> GetCustomerById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CustomerModel>> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
