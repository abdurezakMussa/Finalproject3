using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hobnobReact.Models
{
    public  class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
