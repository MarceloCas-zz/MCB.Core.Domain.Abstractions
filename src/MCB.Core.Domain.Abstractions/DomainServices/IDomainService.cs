using MCB.Core.Domain.Entities.Abstractions;

namespace MCB.Core.Domain.Abstractions.DomainServices
{
    public interface IDomainService<TAggregationRoot>
        where TAggregationRoot : IAggregationRoot
    {

    }
}
