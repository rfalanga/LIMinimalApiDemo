﻿using MinimalApi.DataAccess.Interfaces;
using MinimalApi.Model;

namespace LIMinimalApiDemo.APIs
{
    public static class CustomerApi
    {
        public static void RegisterCustomerAPI(this WebApplication application)
        {
            application.MapGet("/customers", GetAllCustomers);
            application.MapGet("/customers/{id}", GetCustomerById);
            application.MapDelete("/customer", DeleteCustomer);
            application.MapPut("/customer", UpdateCustomer);

            //the rest were not in the blog post; I've added them
        }

        private static IResult UpdateCustomer(Customer customer, IRepository repository)
        {
            //Update logic goes here (this is how it is displayed on the blog site)

            //Now I'm adding logic to handle the update; this wasn't in the blog post
            var customerResult = repository.UpdateCustomer(customer);
            if (customerResult == null)
            {
                return Results.NotFound();
            }

            return Results.Ok();
        }

        public static IResult GetAllCustomers(IRepository repository)
        {
            var customers = repository.GetAllCustomers();

            return Results.Ok(customers);
        }

        public static IResult GetCustomerById(int id, IRepository repository)
        {
            return Results.Ok(repository.GetCustomerById(id));
        }

        public static IResult SaveCustomer(Customer customer, IRepository repository)
        {
            //Save logic here (the author of this article, I think intended to convey there might be
            //others things you'd need to do here, which he's skipping. Also note that apparently the
            //author is using Postman to add the new Customer. He skips that part. Urg!

            //this return value will return the newly added customer - note: that's not done
            return Results.Created($"/customers/{customer.Id}", customer);
        }
        public static IResult DeleteCustomer(int customerId, IRepository repository)
        {
            //Same thing here as in the SaveCustomer method. The author only shows the barebones part of
            //deleting a customer, without actually deleting the customer from the repository.

            //Now I'm adding logic to handle the update; this wasn't in the blog post

            if (repository.DeleteCustomerById(customerId))
            {
                return Results.Accepted();  //original code
            }

            return Results.BadRequest();
        }

    }
}
