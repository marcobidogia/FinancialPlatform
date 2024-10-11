using Storage.Entities;
using Storage.Tests.fixtures;

namespace Storage.Tests;

public class InteractionWithSqlDatabase
{
    [Fact]
    public void StoreIncomeMovement()
    {
        // Arrange
        var fixture = new MovementContextFixture();
        var movement = new IncomeMovement();
        
        // Act
        var context = fixture.CreateDbContext();
        context.IncomeMovements.Add(movement);
        context.SaveChanges();

        // Assert
        Assert.NotNull(context.IncomeMovements.Find(movement.Id));
        
        context.IncomeMovements.Remove(movement);
        context.SaveChanges();
    }
    
    
}