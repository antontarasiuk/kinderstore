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

		[Display(Name = "наименование")]
		public string Name { get; set; }

		[Display(Name = "Артикул")]
		public string Code { get; set; }

		[Display(Name = "Размеры")]
		public string Size { get; set; }

		[Display(Name = "Материал")]
		public string Material { get; set; }

		[Display(Name = "Описание")]
		public string Description { get; set; }

		[Display(Name = "Категория/Группа товаров")]
		public string Category { get; set; }

		[Display(Name = "Цена")]
		public decimal Price { get; set; }

		public string Image { get; set; }

		public byte[] ImageData { get; set; }

		public string ImageMimeType { get; set; }

		[Display(Name = "Доступность")]
		public bool IsAvailable { get; set; }
	}
}
