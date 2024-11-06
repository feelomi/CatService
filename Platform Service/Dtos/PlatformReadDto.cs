namespace PlatformService.Dtos
{
    public class PlatformReadDto
    {
        
         public int Id { get; set; }
       
        public required string CatName { get; set; }
      
         public int Age { get; set; }
         
        public required string Breed { get; set; }
     
        public required string Description { get; set; }
    }
}