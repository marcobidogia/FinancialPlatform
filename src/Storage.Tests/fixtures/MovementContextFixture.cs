using Microsoft.EntityFrameworkCore;
using Storage.contexts;

namespace Storage.Tests.fixtures;

public class MovementContextFixture
{
    private const string ConnectionString = "Server=localhost;Database=FinancialPlatform;Integrated Security=SSPI;TrustServerCertificate=True";
    
    public MovementTrackerDbContext CreateDbContext() {
        var options = new DbContextOptionsBuilder<MovementTrackerDbContext>()
            .UseSqlServer(ConnectionString)
            .Options;
        return new MovementTrackerDbContext(options);
    }
}