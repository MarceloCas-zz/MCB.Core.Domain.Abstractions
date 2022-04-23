using MCB.Core.Domain.Abstractions.DomainNotifications.Models;
using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Observer;

namespace MCB.Core.Domain.Abstractions.DomainNotifications
{
    public interface IDomainNotificationEventHandler<TDomainNotification>
        : ISubscriber<TDomainNotification>
        where TDomainNotification : DomainNotification
    {
        // Properties
        IEnumerable<TDomainNotification> ReceivedDomainNotificationsCollection { get; }

        // Methods
        bool HasDomainNotifications();
    }
}
