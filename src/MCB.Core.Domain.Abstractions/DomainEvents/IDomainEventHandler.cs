namespace MCB.Core.Domain.Abstractions.DomainEvents
{
    public interface IDomainEventHandler
    {
        // Properties
        IEnumerable<IDomainEvent> RaisedDomainEvents { get; }

        // Methods
        bool HasDomainEvents();
    }
}
