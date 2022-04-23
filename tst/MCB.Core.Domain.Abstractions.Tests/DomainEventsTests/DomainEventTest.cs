using FluentAssertions;
using MCB.Core.Domain.Abstractions.DomainEvents.Models;
using System;
using Xunit;

namespace MCB.Core.Domain.Abstractions.Tests.DomainEventsTests
{
    public class DomainEventTest
    {
        [Fact]
        public void DomainEvent_Should_Correctly_Initialized()
        {
            // Arrange and Act
            var domainEvent = new DomainEvent();

            // Assert
            domainEvent.EventId.Should().NotBe(Guid.Empty);
            domainEvent.CorrelationId.Should().Be(Guid.Empty);
            domainEvent.TimeStamp.Should().BeAfter(default);
            domainEvent.EventDataType.Should().BeNullOrWhiteSpace();
            domainEvent.EventDataSchema.Should().BeNullOrWhiteSpace();
            domainEvent.EventData.Should().BeNullOrWhiteSpace();
            domainEvent.TenantId.Should().Be(Guid.Empty);
            domainEvent.ExecutionUser.Should().BeNullOrWhiteSpace();
            domainEvent.SourcePlatform.Should().BeNullOrWhiteSpace();
        }
    }
}
