﻿using System;
using Microsoft.AspNetCore.Http;
using ProMusic.Helper.DTOs.BrandDto;

namespace ProMusic.Helper.DTOs.ProductDto
{
    public class ProductGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CostPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public double? Rate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int BrandId { get; set; }
        public int SubCategoryId { get; set; }
        public string Image { get; set; }
        public string Desc { get; set; }
    }
}
