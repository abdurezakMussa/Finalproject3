using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hobnobReact.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Menus = new HashSet<Menu>();
        }

        public int Id { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int Zipcode { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Menu> Menus { get; set; }
    }
}
