using System.ComponentModel.DataAnnotations;

namespace hobnobReact.Dtos
{
    public class MenuUpdateDto
    {
      
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

    }
}