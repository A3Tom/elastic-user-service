namespace UserService.Domain.Entities;

#pragma warning disable IDE1006 // Naming Styles - Source data name is immutable
public record User(string first_name, string last_name, string gender, string email);
#pragma warning restore IDE1006 // Naming Styles

