using System;
using RetailDemo.Models;
using RetailDemo.Services.Invoice;
using Xunit;

namespace RetailDemo.Tests
{
    public class DiscountCalculateTests
    {
        #region Last Calculate

        [Theory]
        [InlineData(990, 945)]
        public void CalculateForPrice_SuccessfullTest(decimal totalPrice, decimal expectedResult)
        {
            InvoiceService invoiceService = new InvoiceService();
            var result = invoiceService.CalculateForPrice(totalPrice);
            Assert.Equal(result, expectedResult);
        }

        [Theory]
        [InlineData(990, 960)]
        public void CalculateForPrice_FailureTest(decimal totalPrice, decimal expectedResult)
        {
            InvoiceService invoiceService = new InvoiceService();
            var result = invoiceService.CalculateForPrice(totalPrice);
            Assert.NotEqual(result, expectedResult);
        }

        #endregion Last Calculate


        #region Normal Scenario Calculate

        [Fact]
        public void CalculateDiscount_SuccessfullTest()
        {
            CustomerModel customerModel = new CustomerModel { Id = 1, Type = CustomerType.LoyalCustomer };
            InvoiceModel invoiceModel = new InvoiceModel { Id = 1, Type = InvoiceType.Normal, TotalPrice = 990 };
            InvoiceService invoiceService = new InvoiceService();
            var result = invoiceService.CalculateDiscount(customerModel, invoiceModel);

            Assert.Equal(Convert.ToDecimal(940.5), result);

        }

        [Fact]
        public void CalculateDiscount_FailureTest()
        {
            CustomerModel customerModel = new CustomerModel { Id = 1, Type = CustomerType.LoyalCustomer };
            InvoiceModel invoiceModel = new InvoiceModel { Id = 1, Type = InvoiceType.Normal, TotalPrice = 990 };
            InvoiceService invoiceService = new InvoiceService();
            var result = invoiceService.CalculateDiscount(customerModel, invoiceModel);

            Assert.NotEqual(945, result);

        }

        #endregion


    }
}
