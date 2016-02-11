using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace KinderStore.Domain.Entities
{
	public class Product
	{
		[HiddenInput(DisplayValue = false)]
		public int ProductId { get; set; }

		[Display(Name = "Создано")]
		public DateTime? Created { get; set; }

		[Display(Name = "Последнее изменение")]
		public DateTime? LastModified { get; set; }

		[Display(Name = "Наименование")]
		[Required(ErrorMessage = "Пожалуйста, введите название товара")]
		public string Name { get; set; }

		[Display(Name = "Артикул")]
		[Required(ErrorMessage = "Пожалуйста, введите артикул товара")]
		public string Code { get; set; }

		[Display(Name = "Размеры")]
		public string Size { get; set; }

		[Display(Name = "Материал")]
		[Required(ErrorMessage = "Пожалуйста, введите материал товара")]
		public string Material { get; set; }

		[DataType(DataType.MultilineText)]
		[Display(Name = "Описание")]
		public string Description { get; set; }

		[Display(Name = "Категория/Группа товаров")]
		[Required(ErrorMessage = "Пожалуйста, введите категорию/группу товара")]
		public string Category { get; set; }

		[Display(Name = "Цена")]
		public decimal Price { get; set; }

		public string Image { get; set; }

		public byte[] ImageData { get; set; }

		public string ImageMimeType { get; set; }

		[Display(Name = "Доступность")]
		[Required(ErrorMessage = "Пожалуйста, укажите доступность товара: True(Доступен) или False(Не доступен)")]
		public bool IsAvailable { get; set; }
	}
}
