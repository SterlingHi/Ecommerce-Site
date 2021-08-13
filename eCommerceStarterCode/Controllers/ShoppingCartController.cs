﻿using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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


        //// Get by UserId
        //[HttpGet("{UserId}")]
        //public IActionResult Get([FromBody]ShoppingCart value)
        //{
        //    var shoppingCart = _context.ShoppingCarts;
        //    var specificUserCart = shoppingCart.Where(sc => sc.UserId == value.UserId);
        //    return Ok(specificUserCart);
        //}


        [HttpGet("{UserId}")]
        public IActionResult GetShoppingCartByUserId(string UserId)
        {
            var ShoppingCart = _context.ShoppingCarts.Where(sc => sc.UserId == UserId);
            if (ShoppingCart == null)
            {
                return NotFound();
            }
            return Ok(ShoppingCart);
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
        //add by ProudctId



        //Start requests here.
        //public IActionResult YouNameIt()
        //{
        //    return View();
        //}
    }
}

