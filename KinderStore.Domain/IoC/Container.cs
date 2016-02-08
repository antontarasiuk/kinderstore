using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Practices.Unity;

namespace KinderStore.Domain.IoC
{
	public sealed class Container : IContainer
	{
		private readonly IUnityContainer _container;
		private bool _disposed;

		public Container(IUnityContainer container)
		{
			_container = container;
			if (_container.Parent == null)
			{
				_container.RegisterInstance<IContainer>(this);
			}
		}

		/// <inheritdoc />
		public IContainer RegisterType(Type from, Type to, string name, LifeTime lifeTime)
		{
			switch (lifeTime)
			{
				case LifeTime.ContainerControlled:
					_container.RegisterType(from, to, name, new ContainerControlledLifetimeManager());
					break;
				case LifeTime.PerResolve:
				default:
					_container.RegisterType(from, to, name);
					break;
			}
			return this;
		}

		/// <inheritdoc />
		public IContainer RegisterInstance(Type t, string name, object instance)
		{
			_container.RegisterInstance(t, name, instance);
			return this;
		}

		/// <inheritdoc />
		public object Resolve(Type type, string name)
		{
			return _container.Resolve(type, name);
		}

		/// <inheritdoc />
		public IEnumerable<object> ResolveAll(Type type)
		{
			return _container.ResolveAll(type);
		}

		/// <inheritdoc />
		public bool IsRegistered(Type type, string name)
		{
			return _container.IsRegistered(type, name);
		}

		private void Dispose(bool disposing)
		{
			if (_disposed)
			{
				return;
			}

			_disposed = true;
			if (disposing)
			{
				//Here we must dispose managed resources
			}
			//Here we must dispose unmanaged resources and LOH objects
			_container.Dispose();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <inheritdoc />
		public void Teardown(object instance)
		{
			_container.Teardown(instance);
		}

		/// <inheritdoc />
		public IContainer CreateChildContainer()
		{
			IUnityContainer childContainer = _container.CreateChildContainer();
			return new Container(childContainer);
		}

		~Container()
		{
			try
			{
				Dispose(false);
			}
			catch (Exception)
			{
				// Ignore all the exceptions
			}
		}
	}


}
