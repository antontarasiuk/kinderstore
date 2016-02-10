using System.Data.Entity;
using KinderStore.Domain.Entities;

namespace KinderStore.Domain.Concrete
{
	public class EFDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
	}
}
