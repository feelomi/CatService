using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public class PlatformCreateDto
    {
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
