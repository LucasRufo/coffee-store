using CoffeeStore.Auth.Api.Requests;

namespace CoffeeStore.Auth.Api.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        app.MapPost("/users", CreateUser);
    } 

    private static IResult CreateUser(CreateUserRequest createUserRequest)
    {
        return Results.Ok(createUserRequest);
    }
}
