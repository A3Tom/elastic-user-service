using UserService.Domain.Entities;

namespace UserService.Api.ViewModels;

public class UserVM
{
    public string FirstName { get; init; } = string.Empty;
    public string Surname { get; init; } = string.Empty;
    public string? EmailAddress { get; init; }
    public string? Gender { get; init; }

    public static explicit operator UserVM(User entity)
        => new()
        {
            FirstName = entity.first_name,
            Surname = entity.last_name,
            EmailAddress = entity.email,
            Gender = entity.gender
        };
}
