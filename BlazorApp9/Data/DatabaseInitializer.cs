using Microsoft.EntityFrameworkCore;

namespace BlazorApp9.Data
{
    public class DatabaseInitializer
    {
        public static void Initialize()
        {
            var options = new DbContextOptionsBuilder<VirtualTourDbContext>()
                .UseSqlite("Data Source=virtualtour.db")
                .Options;

            using var context = new VirtualTourDbContext(options);
            context.Database.Migrate();
        }
    }
}
