using MCB.Core.Domain.Abstractions.DomainEvents.Models;
using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Observer;

namespace MCB.Core.Domain.Abstractions.DomainEvents
{
    public interface IDomainEventHandler<TDomainEvent>
        : ISubscriber<TDomainEvent>
        where TDomainEvent : DomainEvent
    {
        // Properties
        IEnumerable<TDomainEvent> RaisedDomainEventsCollection { get; }

        // Methods
        bool HasDomainEvents();
    }
}
