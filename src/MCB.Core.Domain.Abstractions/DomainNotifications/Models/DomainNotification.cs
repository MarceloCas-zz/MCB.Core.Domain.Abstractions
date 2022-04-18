using MCB.Core.Domain.Abstractions.DomainNotifications.Enums;

namespace MCB.Core.Domain.Abstractions.DomainNotifications.Models
{
    public struct DomainNotification
    {
        // Properties
        public DomainNotificationType DomainNotificationType { get; }
        public string DomainEntityTypeFullName { get; }
        public string Code { get; }
        public string Description { get; }

        // Constructors
        public DomainNotification(
            DomainNotificationType domainNotificationType,
            string domainEntityTypeFullName,
            string code,
            string description
        )
        {
            DomainNotificationType = domainNotificationType;
            DomainEntityTypeFullName = domainEntityTypeFullName;
            Code = code;
            Description = description;
        }
    }
}
