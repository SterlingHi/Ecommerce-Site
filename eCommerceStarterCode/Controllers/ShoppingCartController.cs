using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/shoppingcart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }
               

        [HttpGet(), Authorize]
        public IActionResult Get()
        {
            var shoppingCart = _context.ShoppingCarts;
            var specificCart = shoppingCart.Where(sc => sc.UserId == User.FindFirstValue("id"));
            return Ok(specificCart);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ShoppingCart value)
        {
            _context.ShoppingCarts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpDelete("{ProudctId}/{UserId}")]
        public IActionResult Remove(int ProudctId, string UserId)
        {
            var deleteProduct = _context.ShoppingCarts.Where(dp => dp.UserId == UserId && dp.ProductId == ProudctId).SingleOrDefault();
            if (deleteProduct == null)
            {
                return NotFound();
            }
            _context.ShoppingCarts.Remove(deleteProduct);
            _context.SaveChanges();
            return Ok(deleteProduct);
        }
    }
}

