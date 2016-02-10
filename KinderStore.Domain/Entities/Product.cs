using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderStore.Domain.Entities
{
	public class Product
	{
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public string Size { get; set; }
		public string Material { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
		public string Image { get; set; }
		public bool IsAvailable { get; set; }
	}
}
