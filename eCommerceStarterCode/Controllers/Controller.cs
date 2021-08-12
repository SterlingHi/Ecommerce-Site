using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public Controller(ApplicationDbContext context)
        {
            _context = context;
        }
        // <baseurl>/api/users/user
        [HttpGet("user"), Authorize]
        public IActionResult GetCurrentUser()
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Find(userId);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // <baseurl>/api/users/product
        [HttpPost("product/{id}")]
        public IActionResult AddAProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _context.Products.Find(id);
            if (product == null)
            {
                product.ProductId = (int) id;
                product.Name = "Placeholder name";
                product.Description = "Placeholder description";
                product.CategoryId = 0;
                product.Category = new Category();
                product.Price = 0.00;
                product.Rating = 0.00;
                _context.SaveChanges();
            }
            return Ok(product);
        }
    }
}
