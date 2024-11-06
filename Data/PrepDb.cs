using PlatformService.Models;

namespace PlatformService.Data{

public static class PrepDb
{
public static void PrepPopulation(IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
            {

                SeedData(serviceScope.ServiceProvider.GetRequiredService<AppDbContext>());

            }
    }


        private static void SeedData(AppDbContext context)
    {
        if(!context.Platforms.Any())
        {
            Console.WriteLine("--> Seeding data...");

            context.Platforms.AddRange(
                new Platform(){Id=1, CatName="Yumi", Age=2, Breed="British ShortHair", Description="Lovely kitty"},
                new Platform() {Id=2, CatName = "Luna", Age = 3, Breed = "Maine Coon", Description = "Fluffy and friendly" },
                new Platform() {Id=3, CatName = "Simba", Age = 4, Breed = "Bengal", Description = "Energetic and playful" }
            );
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("--> We already have data");
        }
    }
}
}