using System.ComponentModel;

namespace RetailDemo.Models
{
    public enum CustomerType
    {
        [Description("Employee")]
        Employee = 1,
        [Description("Affiliate")]
        Affiliate = 2,
        //TODO: this value can get with formula = today - customer's first invoice date
        [Description("Customer for 2 Years")] 
        LoyalCustomer = 3
    }
    /*
     1. If the user is an employee of the store, he gets a 30% discount
2. If the user is an affiliate of the store, he gets a 10% discount
3. If the user has been a customer for over 2 years, he gets a 5% discount.
4. For every $100 on the bill, there would be a $ 5 discount (e.g. for $ 990, you get $ 45
as a discount).
5. The percentage based discounts do not apply on groceries.
6. A user can get only one of the percentage based discounts on a bill.
     */


    public enum ProductType
    {
        [Description("Normal Products")]
        Normal = 1,
        [Description("Grocery Products")]
        Grocery = 2
    }

    public enum InvoiceType
    {
        [Description("Normal Products")]
        Normal = 1,
        [Description("Grocery Products")]
        Grocery = 2
    }
}
