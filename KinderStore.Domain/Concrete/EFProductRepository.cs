using System;
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

		public void SaveProduct(Product product)
		{
			if (product.ProductId == 0)
			{
				product.Created = DateTime.Now;
				context.Products.Add(product);
			}
			else
			{
				Product dbEntry = context.Products.Find(product.ProductId);
				if (dbEntry != null)
				{
					dbEntry.Name = product.Name;
					dbEntry.Category = product.Category;
					dbEntry.Code = product.Code;
					dbEntry.Description = product.Description;
					dbEntry.LastModified = DateTime.Now;
					dbEntry.ImageData = product.ImageData;
					dbEntry.ImageMimeType = product.ImageMimeType;
					dbEntry.IsAvailable = product.IsAvailable;
					dbEntry.Material = product.Material;
					dbEntry.Price = product.Price;
					dbEntry.Size = product.Size;
				}
			}
			context.SaveChanges();
		}

		public Product DeleteProduct(int productId)
		{
			Product dbEntry = context.Products.Find(productId);
			if (dbEntry != null)
			{
				context.Products.Remove(dbEntry);
				context.SaveChanges();
			}
			return dbEntry;
		}
	}
}
