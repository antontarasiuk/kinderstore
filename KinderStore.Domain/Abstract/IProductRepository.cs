using System.Collections.Generic;
using KinderStore.Domain.Entities;

namespace KinderStore.Domain.Abstract
{
	public interface IProductRepository
	{
		IEnumerable<Product> Products { get; }
	}
}
