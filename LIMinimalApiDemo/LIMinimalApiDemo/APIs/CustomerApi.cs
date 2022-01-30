using MinimalApi.DataAccess.Interfaces;

namespace LIMinimalApiDemo.APIs
{
    public static class CustomerApi
    {
        public static void RegisterCustomerAPI(this WebApplication application)
        {
            application.MapGet("/customers", GetAllCustomers);
        }

        public static IResult GetAllCustomers(IRepository repository)
        {
            var customers = repository.GetAllCustomers();

            return Results.Ok(customers);
        }
    }
}
