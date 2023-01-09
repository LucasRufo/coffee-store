namespace CoffeeStore.Auth.Api.Requests;

public class CreateUserRequest
{
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public string ConfirmPassword { get; set; } = "";
}
