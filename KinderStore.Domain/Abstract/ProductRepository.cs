using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinderStore.Domain.Entities;

namespace KinderStore.Domain.Abstract
{
	public class ProductRepository : IProductRepository
	{
		public IEnumerable<Product> Products { get; }
	}
}
