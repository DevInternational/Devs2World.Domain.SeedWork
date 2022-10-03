using Devs2World.Domain.SeedWork;

namespace Devs2World.Domain.SeedWork.SearchableRepository;
public interface ISearchableRepository<Taggregate>
    where Taggregate : AggregateRoot
{
    Task<SearchOutput<Taggregate>> Search(
        SearchInput input,
        CancellationToken cancellationToken
    );
}
