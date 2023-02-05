using Nest;
using UserService.Api.ViewModels;
using UserService.Data.Abstract;
using UserService.Domain.Entities;

namespace UserService.Data.Contexts;
public class UserContext : IUserContext
{
    private readonly IElasticClient _client;

    private readonly string[] _searchFields = {
        "first_name",
        "last_name",
        "email"
    };

    public UserContext()
    {
        var settings = new ConnectionSettings(new Uri("http://localhost:9200"))
            .DefaultIndex("users");
        _client = new ElasticClient(settings);
    }

    public async Task<IEnumerable<UserVM>> SearchForUser(string searchTerm)
    {
        var queryResult = await _client.SearchAsync<User>(x => x
            .Index("users")
            .Query(q => q
                .QueryString(qs => qs
                    .Query($"*{searchTerm}*")
                    .Fields(f => f.Fields(_searchFields))
                )
            )
            .TrackScores());

        return queryResult.Hits
            .Where(x => x.Score == queryResult.MaxScore)
            .Select(x => (UserVM)x.Source);
    }
}
