using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string CatName { get; set; }
        [Required]
         public int Age { get; set; }
         [Required]
        public string Breed { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
