﻿using System;
using AutoMapper;
using ProMusic.Core.Entities;
using ProMusic.Helper.DTOs.BrandDto;
using ProMusic.Helper.DTOs.CategoryDto;
using ProMusic.Helper.DTOs.ProductDto;

namespace ProMusic.Helper.Profiles
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            #region Product

            CreateMap<Product, ProductGetDto>();
            CreateMap<ProductPostDto, Product>();
            CreateMap<Product, ProductListItemDto>();

            #endregion

            #region Category

            CreateMap<Category, CategoryGetDto>();
            CreateMap<CategoryPostDto, Category>();
            CreateMap<Category, CategoryListItemDto>();

            #endregion

            #region Brand

            CreateMap<Brand, BrandGetDto>();
            CreateMap<BrandPostDto, Brand>();
            CreateMap<Brand, BrandListItemDto>();

            #endregion
        }
    }
}
