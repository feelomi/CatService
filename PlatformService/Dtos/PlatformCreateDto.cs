using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public class PlatformCreateDto
    {
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
