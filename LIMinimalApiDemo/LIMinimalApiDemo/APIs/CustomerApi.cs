﻿using MinimalApi.Model;

namespace LIMinimalApiDemo.APIs
{
    public static class CustomerApi
    {
        public static void RegisterCustomerAPI(this WebApplication application)
        {
            application.MapGet("/customers", GetAllCustomers);
        }

        public static IResult GetAllCustomers()
        {
            //var customers = new List<Customer>
            //{
            //    new Customer { Id = 1, FirstName = "George", LastName = "Jones", Age = 70 },
            //    new Customer { Id = 2, FirstName = "Bill", LastName = "Smith", Age = 50 },
            //    new Customer { Id = 3, FirstName = "Juanita", LastName = "Lopez", Age = 35 }
            //};

            //return Results.Ok(customers);
        }
    }
}
