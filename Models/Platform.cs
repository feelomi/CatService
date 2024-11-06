using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public required string CatName { get; set; }
        [Required]
         public int Age { get; set; }
         [Required]
        public required string Breed { get; set; }
        [Required]
        public required string Description { get; set; }
    }
}
