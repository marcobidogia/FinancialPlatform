using Microsoft.EntityFrameworkCore;
using Storage.contexts;

namespace Storage.Tests.fixtures;

public class SqliteDatabaseFixture
{
   private const string ConnectionString = "Data Source=C:/Users/m.bidogia_ottobit/dev/Sqlite-dbs/test/test.db";
    
    public MovementTrackerDbContext CreateDbContext()
    {
        // Configure sqlite options to use in-memory database
        var options = new DbContextOptionsBuilder<MovementTrackerDbContext>()
            .UseSqlite(ConnectionString)
            .Options;
        return new MovementTrackerDbContext(options);
    }
}