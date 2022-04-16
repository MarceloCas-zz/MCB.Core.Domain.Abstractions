namespace MCB.Core.Domain.Abstractions.DomainEvents
{
    public interface IDomainEvent
    {
        Guid EventId { get; }
        Guid CorrelationId { get; }
        DateTimeOffset TimeStamp { get; }
        string EventType { get; }
        string EventSchema { get; }
        Guid TenantId { get; }
        string ExecutionUser { get; }
        string SourcePlatform { get; }
    }
}
