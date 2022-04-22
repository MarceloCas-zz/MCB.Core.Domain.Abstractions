using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Observer;

namespace MCB.Core.Domain.Abstractions.DomainEvents
{
    public interface IDomainEventHandler<TDomainEvent>
        : ISubscriber<TDomainEvent>
        where TDomainEvent : IDomainEvent
    {
        // Properties
        IEnumerable<TDomainEvent> RaisedDomainEventsCollection { get; }

        // Methods
        bool HasDomainEvents();
    }
}
