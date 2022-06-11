using MCB.Core.Domain.Entities.Abstractions;
using MCB.Core.Infra.CrossCutting.DesignPatterns.Validator.Abstractions;

namespace MCB.Core.Domain.Abstractions.DomainEntities.Validators;

public interface IDomainEntityValidator<TDomainEntity>
    : IValidator<TDomainEntity>
    where TDomainEntity : IDomainEntity
{
}
