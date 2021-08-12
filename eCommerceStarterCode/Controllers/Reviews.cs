using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/reviews")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var reviews = _context.Reviews;
            Console.WriteLine(reviews);
            return Ok(reviews);
            
        }
        

        [HttpPost] // Authorize: Reminder this could be changed revolve around the model.
        public IActionResult Post([FromBody] Review obj)
        {
            //var ReviewId = User.FindFirstValue("id");
            //obj.ReviewId = userId;
            _context.Reviews.Add(obj);
            _context.SaveChanges();
            return Ok(obj);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Review obj)
        {
            var review = _context.Reviews.FirstOrDefault(review => review.ReviewId == id);
            review.Description = obj.Description;
            review.Rating = obj.Rating;
            //review.ProductId = obj.Product.ProductId;
            _context.SaveChanges();
            return Ok(review);
        }

        [HttpDelete("(id)")]
        public IActionResult Delete(int id)
        {
            var review = _context.Reviews.FirstOrDefault(rev => rev.ReviewId == id);
            _context.Remove(review);
            _context.SaveChanges();
            return Ok();
        }
    }
}
