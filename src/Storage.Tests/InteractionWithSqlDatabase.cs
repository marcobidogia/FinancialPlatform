using System.Runtime.InteropServices.JavaScript;
using NuGet.Frameworks;
using Storage.Entities;
using Storage.Records;
using Storage.Repositories;
using Storage.Tests.fixtures;

namespace Storage.Tests;

public class InteractionWithSqlDatabase
{
    [Fact]
    public void ShouldStoreAndGetOneData()
    {
        // Arrange
        var fixture = new SqlDatabaseFixture();
        var movement = new IncomeMovement()
        {
            Amount = 32,
            Date = DateTime.Now,
            Notes = "test",
            Category = new IncomeMovementCategory()
            {
                Name = "test category"
            }
        };
        
        // Act
        var context = fixture.CreateDbContext();
        context.IncomeMovements.Add(movement);
        context.SaveChanges();

        // Assert
        Assert.Equivalent(movement, context.IncomeMovements.Find(movement.Id));
        
        context.IncomeMovements.Remove(movement);
        context.IncomeMovementCategories.Remove(movement.Category);
        context.SaveChanges();
    }

    [Fact]
    public void ShouldStoreAndGetDataUsingRepository()
    {
        // Arrange
        var fixture = new SqlDatabaseFixture();
        var context = fixture.CreateDbContext();
        var repo = new MovementTrackerRepository(context);
        var movement = new OutcomeMovement()
        {
            Amount = 32,
            Date = DateTime.Now,
            Notes = "test",
            Category = new OutcomeMovementCategory()
            {
                Name = "test category"
            }
        };

        // Act
        context.OutcomeMovements.Add(movement);
        context.SaveChanges();

        // Assert
        Assert.Equivalent(movement, repo.getOutcomeMovement(movement.Id));
        
        context.OutcomeMovements.Remove(movement);
        context.SaveChanges();
    }
}