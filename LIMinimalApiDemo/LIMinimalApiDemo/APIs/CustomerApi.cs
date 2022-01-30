using MinimalApi.DataAccess.Interfaces;

namespace LIMinimalApiDemo.APIs
{
    public static class CustomerApi
    {
        public static void RegisterCustomerAPI(this WebApplication application)
        {
            application.MapGet("/customers", GetAllCustomers);
            application.MapGet("/customers/{id}", GetCustomerById);
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
    }
}
