using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using static Web2.HWManager;

namespace Web2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application.Add("Key", "12345");
            string Key = (string)Application["Key"];


           
            HWSettings Settings = HWManager.LoadSettings(Server.MapPath("~App_Data/Setting.xml"));
            Application.Add("Settings", Settings);
        }
        void Session_Start(Object sender, EventArgs e)
        {
            if (Application["Counter"] == null)
            {
                Application.Add("Counter", 0);
            }
            int iCounter = Convert.ToInt32(Application["Counter"]);
            iCounter++;
            Application["Counter"] = iCounter.ToString();
            


        }
    }
}
        