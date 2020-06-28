using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hobnobReact.Models
{
    public class Menu
    {
        // public Menu()
        // {
        //     Orderdetail = new HashSet<Orderdetail>();
        // }
        // [key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
      [Required]
      [MaxLength(250)]
        public int Prices { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public string CreatedAt { get; set; }
        [Required]
        public string UpdatedAt { get; set; }
        [Required]
        public int? MenuTypeId { get; set; }
        [Required]
        public int? RestaurantId { get; set; }

        public Menutype MenuType { get; set; }
        public Restaurant Restaurant { get; set; }
        public ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
