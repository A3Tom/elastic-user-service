using MediatR;
using UserService.Api.ViewModels;
using UserService.Data.Abstract;

namespace UserService.Application.Queries.UseCases.Users.Handlers;
public class SearchUsers : IRequestHandler<SearchUsers.Request, IEnumerable<UserVM>>
{
    private readonly IUserContext _userContext;

    public SearchUsers(IUserContext userContext)
    {
        _userContext = userContext;
    }

    public async Task<IEnumerable<UserVM>> Handle(Request request, CancellationToken cancellationToken)
    {
        return await _userContext.SearchForUser(request.SearchTerm);
    }

    public class Request : IRequest<IEnumerable<UserVM>>
    { 
        public string? SearchTerm { get; init; }

        public Request(string? searchTerm)
        {
            SearchTerm = searchTerm;
        }
    }
}
