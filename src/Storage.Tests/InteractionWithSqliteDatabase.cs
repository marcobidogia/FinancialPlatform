using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore.Sqlite.Query.Internal;
using NuGet.Frameworks;
using Storage.Entities;
using Storage.Records;
using Storage.Repositories;
using Storage.Tests.fixtures;

namespace Storage.Tests;

public class InteractionWithSqliteDatabase
{
    [Fact]
    public void ShouldStoreAndGetOneData()
    {
        // Arrange
        var fixture = new SqliteDatabaseFixture();
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
        var fixture = new SqliteDatabaseFixture();
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
        Assert.Equivalent(movement, repo.GetOutcomeMovement(movement.Id));
        
        context.OutcomeMovements.Remove(movement);
        context.SaveChanges();
    }
}