﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProMusic.Helper.DTOs.CategoryDto;
using ProMusic.Helper.Interfaces;

namespace ProMusic.Api.Apps.Member.Controllers
{
    [Route("member/api/[controller]"), ApiController]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        #region Get

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory (int id)
        {
            return Ok(await _categoryService.GetByIdAsync(id));
        }

        #endregion

        #region GetAll

        [HttpGet("")]
        public async Task<IActionResult> GetAllCategories(int page = 1)
        {
            return Ok(await _categoryService.GetAll(page));
        }

        #endregion
    }
}
