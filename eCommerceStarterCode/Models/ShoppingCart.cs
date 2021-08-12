﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        [ForeignKey("IdentityUser")]
        public string UserId { get; set; }
        public User User { get; set; }
     
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public int Quantity { get; set; }
    }
}