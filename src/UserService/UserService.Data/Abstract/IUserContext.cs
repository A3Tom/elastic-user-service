using UserService.Api.ViewModels;

namespace UserService.Data.Abstract;
public interface IUserContext
{
    Task<IEnumerable<UserVM>> SearchForUser(string searchTerm);
}