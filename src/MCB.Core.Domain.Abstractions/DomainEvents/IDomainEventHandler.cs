namespace MCB.Core.Domain.Abstractions.DomainEvents
{
    public interface IDomainEventHandler
    {
        // Properties
        IEnumerable<IDomainEvent> RaisedDomainEventsCollection { get; }

        // Methods
        bool HasDomainEvents();
    }
}
