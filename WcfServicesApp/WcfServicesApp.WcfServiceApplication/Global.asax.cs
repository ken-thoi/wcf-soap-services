using System;
using System.ServiceModel.Activation;
using System.Web.Routing;
using WcfServicesApp.WcfServiceApplication.Helpers;

namespace WcfServicesApp.WcfServiceApplication
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        private void RegisterRoutes(RouteCollection routes)
        {
            //routes.Add(new ServiceRoute("KenService", new ServiceHostFactory(), typeof(KenService)));
            routes.Add(new ServiceRoute("KenService", new HttpsServiceHostFactory(), typeof(KenService)));
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}