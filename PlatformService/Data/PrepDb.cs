using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data{

public static class PrepDb
{
public static void PrepPopulation(IApplicationBuilder app, bool isProd)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
            {

                SeedData(serviceScope.ServiceProvider.GetRequiredService<AppDbContext>(), isProd);

            }
    }


        private static void SeedData(AppDbContext context, bool isProd)
    {
         if(isProd)
            {
                Console.WriteLine("--> Attempting to apply migrations...");
                try
                {
                    context.Database.Migrate();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"--> Could not run migrations: {ex.Message}");
                }
            }
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