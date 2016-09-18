using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PersonalBlog.Entities.Enums;
using PersonalBlog.Logic.Managers;

namespace PersonalBlog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
			DataBaseConfig.Initialize();

            LogManager.LogSiteWork("Site was initialize");
        }
    }
}