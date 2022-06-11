using FluentAssertions;
using MCB.Core.Domain.Abstractions.DomainNotifications.Enums;
using MCB.Core.Domain.Abstractions.DomainNotifications.Models;
using Xunit;

namespace MCB.Core.Domain.Abstractions.Tests.DomainNotificationsTests.ModelsTests;

public class DomainNotificationTest
{
    [Fact]
    public void DomainNotification_Should_Be_Instiated_Correctly()
    {
        // Arrange
        var domainNotificationType = DomainNotificationType.Information;
        var domainEntityTypeFullName = "Customer";
        var code = "MSG_1";
        var description = "MESSAGE_1";

        // Act
        var domainNotification = new DomainNotification(
            domainNotificationType,
            domainEntityTypeFullName,
            code,
            description
        );

        // Assert
        domainNotification.DomainNotificationType.Should().Be(domainNotificationType);
        domainNotification.DomainEntityTypeFullName.Should().Be(domainEntityTypeFullName);
        domainNotification.Code.Should().Be(code);
        domainNotification.Description.Should().Be(description);
    }
}
