using KinderStore.Domain.Abstract;
using KinderStore.Domain.IoC;
using KinderStore.Domain.Logging;

namespace KinderStore.Domain
{
	public class Bootstrapper
	{
		private readonly IContainer container;
		public Bootstrapper()
		{
			container = ApplicationContext.Container;
			Initialize();
		}

		private void Initialize()
		{
			container.RegisterType<ILogger, Log4NetLogger>(LifeTime.ContainerControlled);

			container.RegisterType<IProductRepository, ProductRepository>();
		}
	}
}
