using FluentValidation;
using MCB.Core.Domain.Entities.Abstractions;

namespace MCB.Core.Domain.Abstractions.DomainEntities.Specifications;

public interface IDomainEntitySpecifications<TDomainEntity>
    where TDomainEntity : IDomainEntity
{
    void AddIdIsRequiredSpecification(AbstractValidator<TDomainEntity> validator);
    void AddTenantIdIsRequiredSpecification(AbstractValidator<TDomainEntity> validator);
    void AddCreationInfoIsRequiredSpecification(AbstractValidator<TDomainEntity> validator);
    void AddCreationInfoIsValidSpecification(AbstractValidator<TDomainEntity> validator);
    void AddUpdateInfoIsRequiredSpecification(AbstractValidator<TDomainEntity> validator);
    void AddUpdateInfoIsValidSpecification(AbstractValidator<TDomainEntity> validator);
    void AddRegistryVersionIsRequiredSpecification(AbstractValidator<TDomainEntity> validator);
    void AddRegistryVersionIsValidSpecification(AbstractValidator<TDomainEntity> validator);
}
