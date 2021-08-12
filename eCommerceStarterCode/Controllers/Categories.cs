using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {

            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var catergories = _context.Categories;
            return Ok(catergories);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var category = _context.Categories.FirstOrDefault(category => category.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Category value)
        {
            _context.Categories.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category value)
        {
            var category = _context.Categories.FirstOrDefault(category => category.CategoryId == id);
            category.CategoryName = value.CategoryName;
            _context.SaveChanges();
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(category => category.CategoryId == id);
            _context.Remove(category);
            _context.SaveChanges();
            return Ok();
        }

    }
}



        //[HttpPost]
        //public IActionResult Post ()







