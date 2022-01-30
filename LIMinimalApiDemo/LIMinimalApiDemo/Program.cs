using LIMinimalApiDemo.APIs;
using MinimalApi.DataAccess;
using MinimalApi.DataAccess.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IRepository, CustomerRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//refactoring into the CustomerApi class
app.RegisterCustomerAPI();

app.Run();
