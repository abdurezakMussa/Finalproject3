using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hobnobReact.Models
{
    public  class Orderdetail
    {
        public int Id { get; set; }
[Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        [Required]
        public int? MenuId { get; set; }
        [Required]
        public int? OrderId { get; set; }

        public Menu Menu { get; set; }
        public Order Order { get; set; }
    }
}
