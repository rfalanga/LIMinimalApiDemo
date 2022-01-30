using MinimalApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMinimalApiDemo.APIs
{
    public static class CustomerApi
    {
        public static void RegisterCustomerAPI(this WebApplication application)
        {
            application.MapGet("/customers", GetAllCustomers);
        }

        private static IResult GetAllCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "George", LastName = "Jones", Age = 70 },
                new Customer { Id = 2, FirstName = "Bill", LastName = "Smith", Age = 50 },
                new Customer { Id = 3, FirstName = "Juanita", LastName = "Lopez", Age = 35 }
            };

            return Results.Ok(customers);
        }
    }
}
