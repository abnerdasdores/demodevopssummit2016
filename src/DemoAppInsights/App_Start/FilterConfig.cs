using DemoAppInsights.Attributes;
using System.Web.Mvc;

namespace DemoAppInsights
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AiHandleErrorAttribute());
        }
    }
}
