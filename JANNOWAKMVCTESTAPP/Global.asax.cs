using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace JANNOWAKMVCTESTAPP
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_PostAcquireRequestState(object sender, EventArgs e)
        {
            try
            {
                if (Session["culture"] == null)
                    Session["culture"] = "pl-PL";

                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Session["culture"].ToString());
            }
            catch (Exception ex)
            {

            }
        }
    }
}
