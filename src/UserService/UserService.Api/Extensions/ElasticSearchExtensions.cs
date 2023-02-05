using Nest;
using UserService.Domain.Abstract;

namespace UserService.Api.Extensions;

public static class ElasticSearchExtensions
{
    public static void AddUserElasticSearch(this IServiceCollection services)
    {
        var settings = services
            .BuildServiceProvider()
            .GetRequiredService<IElasticSearchSettings>();

        var connectionSettings = new ConnectionSettings(new Uri(settings.ElasticSearchNodeUrl))
            .DefaultIndex(settings.ElasticSearchDefaultIndex);
        var elasticClient = new ElasticClient(connectionSettings);

        services.AddScoped<IElasticClient>(x => elasticClient);
    }
}
