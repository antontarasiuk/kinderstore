using System.Collections.Generic;
using System.Linq;
using KinderStore.Domain.Abstract;
using KinderStore.Domain.Entities;

namespace KinderStore.Domain.Concrete
{
	public class EFProductRepository : IProductRepository
	{
		private EFDbContext context = new EFDbContext();

		public IEnumerable<Product> Products
		{
			get
			{
				return context.Products;
			}
		}
	}
}
