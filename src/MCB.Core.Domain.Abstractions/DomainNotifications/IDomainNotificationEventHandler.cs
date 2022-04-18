using MCB.Core.Domain.Abstractions.DomainNotifications.Models;

namespace MCB.Core.Domain.Abstractions.DomainNotifications
{
    public interface IDomainNotificationEventHandler
    {
        // Properties
        IEnumerable<DomainNotification> RaisedDomainNotificationsCollection { get; }

        // Methods
        bool HasDomainNotifications();
    }
}
