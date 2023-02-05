using UserService.Domain.Abstract;

namespace UserService.Domain.Settings;
public class UserServiceSettings: IElasticSearchSettings
{
    public string ElasticSearchNodeUrl { get; init; } = string.Empty;
    public string ElasticSearchDefaultIndex { get; init; } = string.Empty;
}
