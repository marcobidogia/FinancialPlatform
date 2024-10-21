using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Storage.contexts;
using Storage.Entities;
using Storage.Tests.fixtures;

namespace MovementTracker.Tests;

public class InterfaceFunctions
{
    [Fact]
    public void ShouldAddOneIncomeMovementInDatabase()
    {
        // Arrange
        var fixture = new SqlDatabaseFixture();
        var dbContextFactoryMock = new Mock<IDbContextFactory<MovementTrackerDbContext>>();
        dbContextFactoryMock.Setup(f => f.CreateDbContext()).Returns(fixture.CreateDbContext); 
        // var tracker = new MovementTrackerService(dbContextFactoryMock.Object);
        // var count = tracker.GetIncomes().Count;

        // Act
        // tracker.AddIncome(new IncomeMovement());

        // Assert
        // Assert.Equal(count + 1, tracker.GetIncomes().Count);
    }
}