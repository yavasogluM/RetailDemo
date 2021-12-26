using System;
using System.Collections.Generic;
using RetailDemo.Models;

namespace RetailDemo.Services.Invoice
{
    public class InvoiceService : IInvoiceService
    {
        public decimal CalculateDiscount(CustomerModel customer, InvoiceModel invoice)
        {
            decimal price = invoice.TotalPrice;
            if (invoice.Type != InvoiceType.Grocery)
            {
                switch (customer.Type)
                {
                    case CustomerType.Employee:
                        price = CalculateForEmployee(invoice);
                        CalculateForPrice(price);
                        return price;
                    case CustomerType.Affiliate:
                        price = CalculateForAffiliate(invoice);
                        CalculateForPrice(price);
                        return price;
                    case CustomerType.LoyalCustomer:
                        price = CalculateForLoyalCustomer(invoice);
                        CalculateForPrice(price);
                        return price;
                }
            }

            
            return price;
        }

        public decimal CalculateForPrice(decimal currentPrice, int discountPrice = 5, decimal price = 100)
        {
            //For every $100 on the bill, there would be a $ 5 discount(e.g. for $ 990, you get $ 45 as a discount).
            var totalDiscount = (Math.Round((currentPrice / price), MidpointRounding.ToZero) * discountPrice);
            currentPrice -=  totalDiscount;
            return currentPrice;
        }

        private decimal CalculateForEmployee(InvoiceModel invoice)
        {
            //If the user is an employee of the store, he gets a 30% discount.
            return CalculatePriceByPercentage(invoice, 30);
        }

        private decimal CalculateForAffiliate(InvoiceModel invoice)
        {
            //If the user is an affiliate of the store, he gets a 10% discount.
            return CalculatePriceByPercentage(invoice, 10);
        }

        private decimal CalculateForLoyalCustomer(InvoiceModel invoice)
        {
            //If the user has been a customer for over 2 years, he gets a 5 % discount.
            return CalculatePriceByPercentage(invoice, 5);
        }

        private decimal CalculatePriceByPercentage(InvoiceModel invoice, decimal percentage) => invoice.TotalPrice - ((invoice.TotalPrice / 100) * percentage);

    }
}
