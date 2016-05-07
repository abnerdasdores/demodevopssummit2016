using System.Configuration;
using System.Data.Entity;

namespace DemoAppInsights.Models
{
    public class DemoAppInsightsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DemoAppInsightsContext()
            :base(ConfigurationManager.ConnectionStrings["DemoAppInsights"].ConnectionString)
        {
        }
    }
}
