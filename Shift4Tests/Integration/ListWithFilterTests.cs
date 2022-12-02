﻿using Xunit;
using Shift4.Internal;
using Shift4.Request;
using Shift4Tests.ModelBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift4Tests.Integration
{
        public class ListWithFilterTests :IntegrationTest
    {
        CustomerRequestBuilder _customerRequestBuilder = new CustomerRequestBuilder();

        [Fact]
        public async Task CustomerListWithFilterTest()
        {
            var customerRequest = _customerRequestBuilder.Build();
            var customer = await _gateway.CreateCustomer(customerRequest);

            var listRequest = new CustomerListRequest(){
                Created = new CreatedFilter(){
                    Gte = customer.Created,
                    Lte = customer.Created,
                }
            };
            var result = await _gateway.ListCustomers(listRequest);
            Assert.Contains(result.List, item => item.Id == customer.Id);
        }
    }
}
