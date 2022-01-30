using LIMinimalApiDemo.APIs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//refactoring into the CustomerApi class
app.RegisterCustomerAPI();

app.Run();
