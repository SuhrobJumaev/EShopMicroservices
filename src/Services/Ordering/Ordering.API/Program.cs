using Ordering.API;
using Ordering.Application;
using Ordering.Infastructure;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();



var app = builder.Build();


app.Run();


//Configure the HTTP request pipeline.