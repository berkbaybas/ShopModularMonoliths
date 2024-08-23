using Catalog;
using Basket;
using Ordering;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//module services: catalog, basket, ordering
builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();
