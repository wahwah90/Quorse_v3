using System.Data.Entity.Migrations;

namespace Quorse.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Quorse.EntityFramework.QuorseDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Quorse";
        }

        protected override void Seed(Quorse.EntityFramework.QuorseDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
