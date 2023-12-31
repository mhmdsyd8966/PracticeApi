﻿using System.ComponentModel.DataAnnotations;

namespace Contracts.Dto
{
    public class OrderRequest
    {
        [Required]
        public string State { get; set; }
        [Required]
        public string Address1 { get; set; }
        public string? Address2 { get; set; }

    }
}
