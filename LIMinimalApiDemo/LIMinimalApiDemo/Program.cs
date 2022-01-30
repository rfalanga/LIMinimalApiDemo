using MinimalApi.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/customers", () =>
{
    return new List<Customer>
    {
        new Customer { Id = 1, FirstName = "George", LastName = "Jones", Age = 70 },
        new Customer { Id = 2, FirstName = "Bill", LastName = "Smith", Age = 50 },
        new Customer { Id = 3, FirstName = "Juanita", LastName = "Lopez", Age = 35 }
    };
});

app.Run();
