﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceBlazor.Shared
{
	public class Product
	{
		public Product()
		{
		}
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string ImageUrl { get; set; } = string.Empty;
		[Column(TypeName ="decimal(18,2)")]
		public decimal Price { get; set; }
	}
}

