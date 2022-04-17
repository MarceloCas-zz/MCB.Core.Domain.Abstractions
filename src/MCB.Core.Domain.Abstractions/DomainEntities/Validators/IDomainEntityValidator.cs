using MCB.Core.Domain.Entities.Abstractions;
using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Validator;

namespace MCB.Core.Domain.Abstractions.DomainEntities.Validators
{
    public interface IDomainEntityValidator<TDomainEntity>
        : IValidator<TDomainEntity>
        where TDomainEntity : IDomainEntity
    {
    }
}
