namespace MCB.Core.Domain.Abstractions.DomainEvents.Models
{
    public class DomainEvent
    {
        // Properties
        public Guid TenantId { get; set; }
        public Guid EventId { get; set; }
        public Guid CorrelationId { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public string? EventType { get; set; }
        public string EventSchema { get; set; }
        public string EventData { get; set; }
        public string ExecutionUser { get; set; }
        public string SourcePlatform { get; set; }

        // Constructors
        public DomainEvent()
        {
            EventId = Guid.NewGuid();
            TimeStamp = DateTimeOffset.UtcNow;
            EventType = GetType().FullName;
            EventSchema = string.Empty;
            EventData = string.Empty;
            ExecutionUser = string.Empty;
            SourcePlatform = string.Empty;
        }
    }
}
