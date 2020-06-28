using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hobnobReact.Models
{
    public  class Order
    {
        public Order()
        {
            Orderdetails = new HashSet<Orderdetail>();
        }
[Required]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        [Required]
        public int? UserId { get; set; }
[Required]
        public User User { get; set; }
        public ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
