using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KinderStore.Domain.Abstract;
using KinderStore.Domain.Entities;

namespace KinderStore.Web.Controllers
{
    public class AdminController : Controller
    {
	    private IProductRepository _repository;

	    public AdminController(IProductRepository repo)
	    {
		    _repository = repo;
	    }

	    public ViewResult Index()
	    {
		    return View(_repository.Products);
	    }

		public ViewResult Create()
		{
			return View("Edit", new Product());
		}

		public ViewResult Edit(int productId)
	    {
			Product product = _repository.Products
				.FirstOrDefault(p => p.ProductId == productId);
			return View(product);
		}

		[HttpPost]
		public ActionResult Edit(Product product, HttpPostedFileBase image = null)
		{
			if (ModelState.IsValid)
			{
				if (image != null)
				{
					product.ImageMimeType = image.ContentType;
					product.ImageData = new byte[image.ContentLength];
					image.InputStream.Read(product.ImageData, 0, image.ContentLength);
				}
				_repository.SaveProduct(product);
				TempData["message"] = string.Format("Изменения товара \"{0}\" были сохранены", product.Name);
				return RedirectToAction("Index");
			}
			else
			{
				// Что-то не так со значениями данных
				return View(product);
			}
		}

		[HttpPost]
		public ActionResult Delete(int productId)
		{
			Product deletedProduct = _repository.DeleteProduct(productId);
			if (deletedProduct != null)
			{
				TempData["message"] = string.Format("Товар \"{0}\"  артикул \"{1}\" был удален",
					deletedProduct.Name, deletedProduct.Code);
			}
			return RedirectToAction("Index");
		}
	}
}