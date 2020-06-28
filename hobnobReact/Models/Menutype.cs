using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hobnobReact.Models
{
    public class Menutype
    {
        public Menutype()
        {
            Menus = new HashSet<Menu>();
        }

        public int Id { get; set; }
[Required]
        public string Typename { get; set; }
        [Required]
        public string CreatedAt { get; set; }
        [Required]
        public string UpdatedAt { get; set; }

        public ICollection<Menu> Menus { get; set; }
    }
}
