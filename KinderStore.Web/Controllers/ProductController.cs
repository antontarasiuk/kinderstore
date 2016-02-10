using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KinderStore.Domain.Abstract;
using KinderStore.Web.Models;

namespace KinderStore.Web.Controllers
{
	public class ProductController : Controller
	{
		private IProductRepository _repository;
		public int pageSize = 2;

		public ProductController(IProductRepository repository)
		{
			_repository = repository;
		}

		public ViewResult List(int page = 1)
		{
			ProductListViewModel model = new ProductListViewModel
			{
				Products = _repository.Products
									  .OrderBy(product => product.ProductId)
									  .Skip((page - 1) * pageSize)
									  .Take(pageSize),

				PagingInfo = new PagingInfo
				{
					CurrentPage = page,
					ItemsPerPage = pageSize,
					TotalItems = _repository.Products.Count()
				}
			};

			return View(model);
		}
	}
}