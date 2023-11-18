﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Cart
    {
        public int Id { get; set; }
        public bool IsCheckout { get; set; }
        [ForeignKey("user")]
        public string UserId { get; set; }

        public Users user { get; set; }
        public List<Product> products { get; set; }
    }
}