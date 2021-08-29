using System.ComponentModel.DataAnnotations;

namespace TheCollection.Dtos
{
    public class LocationDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
    }
}