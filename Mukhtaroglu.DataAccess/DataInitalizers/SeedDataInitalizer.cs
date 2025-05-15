using Microsoft.EntityFrameworkCore;

namespace Mukhtaroglu.DataAccess.DataInitalizers;
public static class SeedDataService
{
    public static void AddSeedData(this ModelBuilder builder)
    {
        builder.AddLanguages();
    }


    private static void AddLanguages(this ModelBuilder builder)
    {
        Language language1 = new() { Id = 1, Name = "Azerbaijani", Code = "AZE", Icon = "https://res.cloudinary.com/dlilcwizx/image/upload/v1730241623/motordoctor.az/fajaznl6ilmlbmo05xbw.png" };
        Language language2 = new() { Id = 2, Name = "English", Code = "ENG", Icon = "https://res.cloudinary.com/dlilcwizx/image/upload/v1730241623/motordoctor.az/mygg6rnd9rkxwc6vlljx.png" };
        Language language3 = new() { Id = 3, Name = "Russian", Code = "RUS", Icon = "https://res.cloudinary.com/dlilcwizx/image/upload/v1730241623/motordoctor.az/upkqfbyfpy7rvmjdwfsm.png" };

        List<Language> languages = [language1, language2, language3];


        builder.Entity<Language>().HasData(languages);
    }
}