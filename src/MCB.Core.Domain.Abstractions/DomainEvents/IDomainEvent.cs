namespace MCB.Core.Domain.Abstractions.DomainEvents
{
    public interface IDomainEvent
    {
        Guid EventId { get; }
        Guid CorrelationId { get; }
        DateTimeOffset TimeStamp { get; }
        string MessageType { get; }
        string MessageSchema { get; }
        Guid TenantId { get; }
        string ExecutionUser { get; }
        string SourcePlatform { get; }
    }
}
