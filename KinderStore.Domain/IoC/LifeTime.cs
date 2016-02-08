using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderStore.Domain.IoC
{
	/// <summary>
	/// Lifetime of instances managed by IoC container.
	/// </summary>
	public enum LifeTime
	{
		/// <summary>
		/// Default value. The container creates an new instance each time when resolves it
		/// </summary>
		PerResolve,

		/// <summary>
		/// The container creates a singleton instance
		/// </summary>
		ContainerControlled
	}
}
