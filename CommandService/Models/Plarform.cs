using System.ComponentModel.DataAnnotations;
using CommandsService.Models;

namespace PlatformService.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string DogName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}
