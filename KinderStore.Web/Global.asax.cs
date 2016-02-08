using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using KinderStore.Domain;
using KinderStore.Domain.IoC;
using KinderStore.Domain.Logging;
using KinderStore.Web.Application;

namespace KinderStore.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
		private IContainer container = ApplicationContext.Container;
		private ILogger logger;

		protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

			new Bootstrapper();

			//setup controller factory to use our IoC
			ControllerBuilder.Current.SetControllerFactory(new ContainerControllerFactory(container));

			logger = container.Resolve<ILogger>();
			logger.Debug("App started!");
		}
    }
}
