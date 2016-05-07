using DemoAppInsights.Models;

namespace DemoAppInsights.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DemoAppInsightsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DemoAppInsights.Models.DemoAppInsightsContext context)
        {
              context.Products.AddOrUpdate(
                p => p.Name,
                new Product { Name = "Product A" },
                new Product { Name = "Product B" },
                new Product { Name = "Product C" },
                new Product { Name = "Product D" },
                new Product { Name = "Product E" },
                new Product { Name = "Product F" }
              );
        }
    }
}
