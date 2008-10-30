using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Kistl.API;
using System.Configuration;

namespace Kistl.Client.ASPNET.Toolkit
{
    public class KistlContextManagerModule : IHttpModule
    {
        public static IKistlContext KistlContext
        {
            get
            {
                return (IKistlContext)HttpContext.Current.Items["__Current_KistlContextManagerModule_KistlContext"];
            }
            private set
            {
                HttpContext.Current.Items["__Current_KistlContextManagerModule_KistlContext"] = value;
            }
        }

        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(context_BeginRequest);
            context.EndRequest += new EventHandler(context_EndRequest);
        }

        void context_EndRequest(object sender, EventArgs e)
        {
            KistlContext.Dispose();
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            if (GuiApplicationContext.Current == null)
            {
                // Code, der beim Starten der Anwendung ausgeführt wird.
                var appCtx = new GuiApplicationContext(HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["configFile"]),
                    Kistl.App.GUI.Toolkit.ASPNET);
            }
            KistlContext = Kistl.API.Client.KistlContext.GetContext();
        }
    }
}
