using CoffeeStore.Auth.Api.Configuration;
using CoffeeStore.Auth.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

RegisterServices(builder.Services);

var app = builder.Build();

RegisterMiddleware(app);

app.Run();

void RegisterServices(IServiceCollection services)
{
    services.AddSwagger();

    services.AddJwtConfiguration(builder.Configuration);
}

void RegisterMiddleware(WebApplication app)
{
    app.UseSwagger();

    app.MapUserEndpoints();
}
