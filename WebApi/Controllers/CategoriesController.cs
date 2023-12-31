﻿using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Category category)
        {
            await _categoryService.Add(category); return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _categoryService.GetListAsync(); return Ok(result);
        }
    }
}
