﻿
using System.Collections.Generic;
using KinderStore.Domain.Entities;

namespace KinderStore.Web.Models
{
	public class ProductListViewModel
	{
		public IEnumerable<Product> Products { get; set; }
		public PagingInfo PagingInfo { get; set; }
	}
}
