using Microsoft.Practices.Unity;
using KinderStore.Domain.IoC;

namespace KinderStore.Domain
{
	/// <summary>
	/// Class that will be used as well-known static class to share information between different kinds of plugin
	/// please avoid usage of this class for other goals, because it will cause bad design everywhere
	/// </summary>
	public static class ApplicationContext
	{
		private static IContainer _container = new Container(new UnityContainer());

		/// <summary>
		/// Gets or sets global container
		/// </summary>
		public static IContainer Container { get { return _container; } }
	}
}

