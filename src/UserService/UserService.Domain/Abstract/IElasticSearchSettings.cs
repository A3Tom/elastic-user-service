namespace UserService.Domain.Abstract;
public interface IElasticSearchSettings
{
    string ElasticSearchNodeUrl { get; init; }
    string ElasticSearchDefaultIndex { get; init; }
}
