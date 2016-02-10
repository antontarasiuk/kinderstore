using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using KinderStore.Domain.Abstract;
using KinderStore.Domain.Concrete;
using KinderStore.Domain.Entities;
using KinderStore.Domain.IoC;
using Moq;

namespace KinderStore.Web.Application
{
	public class ContainerControllerFactory : DefaultControllerFactory
	{
		private IContainer container;

		public ContainerControllerFactory(IContainer container)
		{
			this.container = container;
			Initialize();
		}

		protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
		{
			return controllerType == null ? null : (IController)container.Resolve(controllerType);
		}

		private void Initialize()
		{
			//Mock<IProductRepository> mock = new Mock<IProductRepository>();
			//mock.Setup(m => m.Products).Returns(new List<Product>
			//{
			//	new Product { Name = "Ползунки", Price = 15000 },
			//	new Product { Name = "Распашенка", Price=20000 },
			//	new Product { Name = "Крестильный набор", Price=80000 }
			//});
			//container.RegisterInstance<IProductRepository>(mock.Object);
		}
	}
}
