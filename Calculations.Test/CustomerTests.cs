using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Test
{
    public class CustomerTests
    {
        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = new Customer();
            var error = Assert.Throws<ArgumentException>(()=>customer.GetOrdersByName(""));
            Assert.Equal("Hata",error.Message.ToString());
        }

        [Fact]
        public void CreateCustomerInstance_GivenOrderCount_ReturnObject()
        {
            var calc = CustomerFactory.CreateCustomerInstance(100);
            Assert.IsNotType<LoyalCustomer>(calc);
        }
         
    }
}
