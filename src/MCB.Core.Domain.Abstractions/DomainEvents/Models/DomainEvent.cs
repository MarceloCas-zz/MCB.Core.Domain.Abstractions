namespace MCB.Core.Domain.Abstractions.DomainEvents.Models;

public record DomainEvent
{
    // Properties
    public Guid TenantId { get; set; }
    /// <remarks>
    /// Auto generated
    /// </remarks>
    public Guid EventId { get; set; }
    public Guid CorrelationId { get; set; }
    /// <remarks>
    /// Auto generated
    /// </remarks>
    public DateTimeOffset TimeStamp { get; set; }
    public string EventDataType { get; set; }
    public string EventDataSchema { get; set; }
    public string EventData { get; set; }
    public string ExecutionUser { get; set; }
    public string SourcePlatform { get; set; }

    // Constructors
    public DomainEvent()
    {
        EventId = Guid.NewGuid();
        TimeStamp = DateTimeOffset.UtcNow;
    }
}
