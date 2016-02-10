using System;
using System.Collections.Generic;

namespace KinderStore.Domain.IoC
{
	public interface IContainer : IDisposable
	{
		/// <summary>
		///  Register a type mapping with the container.
		/// </summary>
		/// <param name="name">Name to use for registration</param>
		/// <param name="from">System.Type that will be requested.</param>
		/// <param name="to">System.Type that will actually be returned.</param>
		/// <param name="lifeTime"> controls the lifetime of the returned instance.</param> 
		/// <returns>The IContainer object.</returns>
		IContainer RegisterType(Type from, Type to, string name, LifeTime lifeTime);

		/// <summary>
		/// Register specific instance
		/// </summary>
		/// <param name="t">type of instance</param>
		/// <param name="name">name for instance</param>
		/// <param name="instance">instance</param>
		/// <returns>IoC container</returns>
		IContainer RegisterInstance(Type t, string name, object instance);

		/// <summary>
		/// Resolves the instance of the requested service.
		/// </summary>
		/// <param name="type">Type of instance requested.</param>
		/// <param name="name">Name of registered service you want. May be null.</param>
		/// <returns>The requested service instance.</returns>
		object Resolve(Type type, string name);

		/// <summary>
		/// Resolves all the instances of the requested service.
		/// </summary>
		/// <param name="type">Type of service requested.</param>
		/// <returns>Sequence of service instance objects.</returns>
		IEnumerable<object> ResolveAll(Type type);

		/// <summary>
		/// Check if a particular type/name pair has been registered with the container.
		/// </summary>
		/// <param name="type">type of instance</param>
		/// <param name="name">Name to check registration for.</param>
		/// <returns>True if this type/name pair has been registered, false if not.</returns>
		bool IsRegistered(Type type, string name);

		/// <summary>
		/// Run an existing object through the container, and clean it up. 
		/// </summary>
		/// <param name="instance">The object to tear down.</param>
		void Teardown(object instance);

		/// <summary>
		/// Create child container within base container
		/// </summary>
		/// <returns>child container</returns>
		IContainer CreateChildContainer();
	}
}
