using System.ComponentModel.DataAnnotations;

namespace hobnobReact.Dtos
{
    public class MenuReadDto
    {
      
        public int Id { get; set; }
        
        public string Name { get; set; }
      
        public int Prices { get; set; }
        
        public string Description { get; set; }
       
        public string CreatedAt { get; set; }
      
        public string UpdatedAt { get; set; }
    
        public int? MenuTypeId { get; set; }
   
        public int? RestaurantId { get; set; }
    }
}