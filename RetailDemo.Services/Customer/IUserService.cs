using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RetailDemo.Models;

namespace RetailDemo.Services.Customer
{
    public interface ICustomerService : Base.IBaseService<CustomerModel>
    {
        Task<List<CustomerModel>> GetCustomers();
        Task<CustomerModel> GetCustomerById(int Id);
    }
}
