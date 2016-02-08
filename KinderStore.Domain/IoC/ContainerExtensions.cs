using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace KinderStore.Domain.IoC
{
	public static class ContainerExtensions
	{
		/// <summary>
		///  Register a type with specific members to be injected.
		/// </summary>
		/// <typeparam name="TFrom">System.Type that will be requested.</typeparam>
		/// <typeparam name="TTo">System.Type that will actually be returned.</typeparam>
		/// <param name="container">Container to configure.</param>
		/// <returns>The IContainer object.</returns>
		public static IContainer RegisterType<TFrom, TTo>(this IContainer container)
			where TFrom : class
			where TTo : TFrom
		{
			container.RegisterType(typeof(TFrom), typeof(TTo), null, LifeTime.PerResolve);
			return container;
		}

		/// <summary>
		///  Register a type with specific members to be injected if not registered with the container.
		/// </summary>
		/// <typeparam name="TFrom">System.Type that will be requested.</typeparam>
		/// <typeparam name="TTo">System.Type that will actually be returned.</typeparam>
		/// <param name="container">Container to configure.</param>
		/// <returns>The IContainer object.</returns>
		public static IContainer RegisterTypeIfMissing<TFrom, TTo>(this IContainer container)
			where TFrom : class
			where TTo : TFrom
		{
			if (!container.IsRegistered(typeof(TFrom)))
			{
				container.RegisterType(typeof(TFrom), typeof(TTo), null, LifeTime.PerResolve);
			}
			return container;
		}

		/// <summary>
		///  Register a type with specific members to be injected.
		/// </summary>
		/// <typeparam name="TFrom">System.Type that will be requested.</typeparam>
		/// <typeparam name="TTo">System.Type that will actually be returned.</typeparam>
		/// <param name="container">Container to configure.</param>
		/// <param name="name">Name that will be used to request the type.</param>
		/// <returns>The IContainer object.</returns>
		public static IContainer RegisterType<TFrom, TTo>(this IContainer container, string name)
			where TFrom : class
			where TTo : TFrom
		{
			container.RegisterType(typeof(TFrom), typeof(TTo), name, LifeTime.PerResolve);
			return container;
		}

		/// <summary>
		///  Register a type with specific members to be injected.
		/// </summary>
		/// <typeparam name="TFrom">System.Type that will be requested.</typeparam>
		/// <typeparam name="TTo">System.Type that will actually be returned.</typeparam>
		/// <param name="container">Container to configure.</param>
		/// <param name="name">Name that will be used to request the type.</param>
		/// <param name="lifeTime"> controls the lifetime of the returned instance.</param> 
		/// <returns>The IContainer object.</returns>
		public static IContainer RegisterType<TFrom, TTo>(this IContainer container, string name, LifeTime lifeTime)
			where TFrom : class
			where TTo : TFrom
		{
			container.RegisterType(typeof(TFrom), typeof(TTo), name, lifeTime);
			return container;
		}

		/// <summary>
		///  Register a type with specific members to be injected.
		/// </summary>
		/// <typeparam name="TFrom">System.Type that will be requested.</typeparam>
		/// <typeparam name="TTo">System.Type that will actually be returned.</typeparam>
		/// <param name="container">Container to configure.</param>
		/// <param name="lifeTime"> controls the lifetime of the returned instance.</param> 
		/// <returns>The IContainer object.</returns>
		public static IContainer RegisterType<TFrom, TTo>(this IContainer container, LifeTime lifeTime)
			where TFrom : class
			where TTo : TFrom
		{
			container.RegisterType(typeof(TFrom), typeof(TTo), null, lifeTime);
			return container;
		}

		/// <summary>
		///  Register a type with specific members to be injected if not registered with the container.
		/// </summary>
		/// <typeparam name="TFrom">System.Type that will be requested.</typeparam>
		/// <typeparam name="TTo">System.Type that will actually be returned.</typeparam>
		/// <param name="container">Container to configure.</param>
		/// <param name="lifeTime"> controls the lifetime of the returned instance.</param> 
		/// <returns>The IContainer object.</returns>
		public static IContainer RegisterTypeIfMissing<TFrom, TTo>(this IContainer container, LifeTime lifeTime)
			where TFrom : class
			where TTo : TFrom
		{
			if (!container.IsRegistered(typeof(TFrom)))
			{
				container.RegisterType(typeof(TFrom), typeof(TTo), null, lifeTime);
			}
			return container;
		}

		/// <summary>
		///  Register a type with specific members to be injected.
		/// </summary>
		/// <param name="container">Container to configure.</param>
		/// <param name="tFrom">System.Type that will be requested.</param>
		/// <param name="tTo">System.Type that will actually be returned.</param>
		/// <returns>The IContainer object.</returns>
		public static IContainer RegisterType(this IContainer container, Type tFrom, Type tTo)
		{
			container.RegisterType(tFrom, tTo, null, LifeTime.PerResolve);
			return container;
		}

		/// <summary>
		///  Register a type with specific members to be injected.
		/// </summary>
		/// <param name="container">Container to configure.</param>
		/// <param name="tFrom">System.Type that will be requested.</param>
		/// <param name="tTo">System.Type that will actually be returned.</param>
		/// <param name="lifeTime"> controls the lifetime of the returned instance.</param> 
		/// <returns>The IContainer object.</returns>
		public static IContainer RegisterType(this IContainer container, Type tFrom, Type tTo, LifeTime lifeTime)
		{
			container.RegisterType(tFrom, tTo, null, lifeTime);
			return container;
		}

		/// <summary>
		/// Register an instance with the container.
		/// </summary>
		/// <typeparam name="T">Type of instance</typeparam>
		/// <param name="container">Container to configure.</param>
		/// <param name="instance">Instance</param>
		/// <returns>The IContainer object</returns>
		public static IContainer RegisterInstance<T>(this IContainer container, T instance) where T : class
		{
			container.RegisterInstance(typeof(T), null, instance);
			return container;
		}

		/// <summary>
		/// Register an instance with the container if not registered with the container.
		/// </summary>
		/// <typeparam name="T">Type of instance</typeparam>
		/// <param name="container">Container to configure.</param>
		/// <param name="instance">Instance</param>
		/// <returns>The IContainer object</returns>
		public static IContainer RegisterInstanceIfMissing<T>(this IContainer container, T instance) where T : class
		{
			if (!container.IsRegistered(typeof(T)))
			{
				container.RegisterInstance(typeof(T), null, instance);
			}
			return container;
		}

		/// <summary>
		/// Register an instance with the container.
		/// </summary>
		/// <param name="container">Container to configure.</param>
		/// <param name="t">Type of instance.</param>
		/// <param name="instance">Instance.</param>
		/// <returns>The IContainer object.</returns>
		public static IContainer RegisterInstance(this IContainer container, Type t, object instance)
		{
			container.RegisterInstance(t, null, instance);
			return container;
		}

		/// <summary>
		/// Register an instance if it's not registered in the container.
		/// </summary>
		/// <param name="container">Container to configure.</param>
		/// <param name="t">Type of instance.</param>
		/// <param name="instance">Instance.</param>
		/// <returns>The IContainer object.</returns>
		public static IContainer RegisterInstanceIfMissing(this IContainer container, Type t, object instance)
		{
			if (!container.IsRegistered(t))
			{
				container.RegisterInstance(t, null, instance);
			}
			return container;
		}

		/// <summary>
		/// Register an instance with the container.
		/// </summary>
		/// <param name="container">Container to configure.</param>
		/// <param name="t">Type of instance</param>
		/// <param name="name">Name for instance</param>
		/// <param name="instance">Instance</param>
		/// <returns>The IContainer object</returns>
		public static IContainer RegisterInstance(this IContainer container, Type t, string name, object instance)
		{
			container.RegisterInstance(t, name, instance);
			return container;
		}

		/// <summary>
		/// Register an instance if it's not registered in the container.
		/// </summary>
		/// <param name="container">Container to configure.</param>
		/// <param name="t">Type of instance</param>
		/// <param name="name">Name for instance</param>
		/// <param name="instance">Instance</param>
		/// <returns>The IContainer object</returns>
		public static IContainer RegisterInstanceIfMissing(this IContainer container, Type t, string name, object instance)
		{
			if (!container.IsRegistered(t, name))
			{
				container.RegisterInstance(t, name, instance);
			}
			return container;
		}

		/// <summary>
		/// Register an instance with the container.
		/// </summary>
		/// <typeparam name="T">Type of instance</typeparam>
		/// <param name="container">Container to configure.</param>
		/// <param name="name">Name for instance</param>
		/// <param name="instance">Instance</param>
		/// <returns>The IContainer object</returns>
		public static IContainer RegisterInstance<T>(this IContainer container, string name, T instance) where T : class
		{
			container.RegisterInstance(typeof(T), name, instance);
			return container;
		}

		/// <summary>
		/// Resolve an instance of the default requested type from the container.
		/// </summary>
		/// <param name="container">Container to resolve from.</param>
		/// <returns>The requested service instance.</returns>
		public static T Resolve<T>(this IContainer container)
		{
			return (T)container.Resolve(typeof(T), null);
		}

		/// <summary>
		/// Resolve an instance of the default requested type from the container.
		/// </summary>
		/// <typeparam name="T">System.Type of object to get from the container.</typeparam>
		/// <param name="container">Container to resolve from.</param>
		/// <param name="name">Name of the object to retrieve.</param>
		/// <returns>The requested service instance.</returns>
		public static T Resolve<T>(this IContainer container, string name)
		{
			return (T)container.Resolve(typeof(T), name);
		}

		/// <summary>
		/// Resolve an instance of the default requested type from the container.
		/// </summary>
		/// <param name="container">Container to resolve from.</param>
		/// <param name="type">System.Type of object to get from the container.</param>
		/// <returns>The requested service instance.</returns>
		public static object Resolve(this IContainer container, Type type)
		{
			return container.Resolve(type, null);
		}

		/// <summary>
		/// Return instances of all registered types requested.
		/// </summary>
		/// <typeparam name="T">The type requested.</typeparam>
		/// <param name="container">System.Type of object to get from the container.</param>
		/// <returns>Set of objects of type T.</returns>
		public static IEnumerable<T> ResolveAll<T>(this IContainer container)
		{
			return container.ResolveAll(typeof(T)).Cast<T>();
		}

		/// <summary>
		/// Return instances of all registered types requested.
		/// </summary>
		/// <param name="container">System.Type of object to get from the container.</param>
		/// <param name="type">System.Type of object to get from the container.</param>
		/// <returns>Set of objects of type T.</returns>
		public static IEnumerable<object> ResolveAll(this IContainer container, Type type)
		{
			return container.ResolveAll(type);
		}

		/// <summary>
		/// Check if a particular type has been registered with the container with the default name.
		/// </summary>
		/// <typeparam name="T">Type to check registration for.</typeparam>
		/// <param name="container">Container to inspect.</param>
		/// <returns>True if this type/name pair has been registered, false if not.</returns>
		public static bool IsRegistered<T>(this IContainer container)
		{
			return container.IsRegistered(typeof(T), null);
		}

		/// <summary>
		/// Check if a particular type has been registered with the container with the default name.
		/// </summary>
		/// <param name="container">Container to inspect.</param>
		/// <param name="type">Type to check registration for.</param>
		/// <returns>True if this type/name pair has been registered, false if not.</returns>
		public static bool IsRegistered(this IContainer container, Type type)
		{
			return container.IsRegistered(type, null);
		}

		/// <summary>
		/// Check if a particular type has been registered with the container with the default name.
		/// </summary>
		/// <typeparam name="T">Type to check registration for.</typeparam>
		/// <param name="container">Container to inspect.</param>
		/// <param name="name">Name to check registration for.</param>
		/// <returns>True if this type/name pair has been registered, false if not.</returns>
		public static bool IsRegistered<T>(this IContainer container, string name)
		{
			return container.IsRegistered(typeof(T), name);
		}
	}
}
