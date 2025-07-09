using Microsoft.EntityFrameworkCore;

namespace Mukhtaroglu.DataAccess.DataInitalizers;
public static class SeedDataService
{
    public static void AddSeedData(this ModelBuilder builder)
    {
        builder.AddLanguages();
        builder.AddSettings();
    }


    private static void AddLanguages(this ModelBuilder builder)
    {
        Language language1 = new() { Id = 1, Name = "Azerbaijani", Code = "AZE", Icon = "https://res.cloudinary.com/dlilcwizx/image/upload/v1730241623/motordoctor.az/fajaznl6ilmlbmo05xbw.png" };
        Language language2 = new() { Id = 2, Name = "English", Code = "ENG", Icon = "https://res.cloudinary.com/dlilcwizx/image/upload/v1730241623/motordoctor.az/mygg6rnd9rkxwc6vlljx.png" };
        Language language3 = new() { Id = 3, Name = "Russian", Code = "RUS", Icon = "https://res.cloudinary.com/dlilcwizx/image/upload/v1730241623/motordoctor.az/upkqfbyfpy7rvmjdwfsm.png" };

        List<Language> languages = [language1, language2, language3];


        builder.Entity<Language>().HasData(languages);
    }

    private static void AddSettings(this ModelBuilder builder)
    {
        Setting s1 = new() { Id = 1, Key = "CustomerCount" };
        Setting s2 = new() { Id = 2, Key = "ProductCount" };
        Setting s3 = new() { Id = 3, Key = "MagazineCount" };
        Setting s4 = new() { Id = 4, Key = "CerificateCount" };
        Setting s5 = new() { Id = 5, Key = "FacebookLink" };
        Setting s6 = new() { Id = 6, Key = "InstagramLink" };
        Setting s7 = new() { Id = 7, Key = "TiktokLink" };
        Setting s8 = new() { Id = 8, Key = "FooterDescription" };
        Setting s9 = new() { Id = 9, Key = "PhoneNumber" };
        Setting s10 = new() { Id = 10, Key = "Email" };
        Setting s11 = new() { Id = 11, Key = "WhatsappLink" };
        Setting s12 = new() { Id = 12, Key = "AboutTitle" };
        Setting s13 = new() { Id = 13, Key = "AboutDescription" };
        Setting s14 = new() { Id = 14, Key = "ContactTitle" };
        Setting s15 = new() { Id = 15, Key = "ContactDescription" };
        Setting s16 = new() { Id = 16, Key = "FAQTitle" };
        Setting s17 = new() { Id = 17, Key = "FAQDescription" };
        Setting s18 = new() { Id = 18, Key = "Address" };
        Setting s19 = new() { Id = 19, Key = "HomeSection1Title" };
        //Setting s20 = new() { Id = 20, Key = "HomeSection1Description" };
        Setting s21 = new() { Id = 21, Key = "HomeSection2Title" };
        Setting s22 = new() { Id = 22, Key = "HomeSection2Description" };
        Setting s23 = new() { Id = 23, Key = "HomeSection3Title" };
        Setting s24 = new() { Id = 24, Key = "HomeSection3Description" };
        Setting s25 = new() { Id = 25, Key = "HomeSection4Title" };
        Setting s26 = new() { Id = 26, Key = "HomeSection4Description" };
        Setting s27 = new() { Id = 27, Key = "HomeSection5Title" };
        Setting s28 = new() { Id = 28, Key = "HomeSection5Description" };
        Setting s29 = new() { Id = 29, Key = "ContactFormTitle" };
        Setting s30 = new() { Id = 30, Key = "ContactFormDescription" };



        List<Setting> settings = [s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19,  s21, s22, s23, s24, s25, s26, s27, s28, s29, s30];

        List<SettingLanguage> settingLanguages = new()
        {
            // CustomerCount
            new() { Id = 1, LanguageId = 1, SettingId = 1, Value = "100" },
            new() { Id = 2, LanguageId = 2, SettingId = 1, Value = "100" },
            new() { Id = 3, LanguageId = 3, SettingId = 1, Value = "100" },
        
            // ProjectCount
            new() { Id = 4, LanguageId = 1, SettingId = 2, Value = "250" },
            new() { Id = 5, LanguageId = 2, SettingId = 2, Value = "250" },
            new() { Id = 6, LanguageId = 3, SettingId = 2, Value = "250" },
        
            // YearsOfExperience
            new() { Id = 7, LanguageId = 1, SettingId = 3, Value = "10" },
            new() { Id = 8, LanguageId = 2, SettingId = 3, Value = "10" },
            new() { Id = 9, LanguageId = 3, SettingId = 3, Value = "10" },
        
            // CerificateCount
            new() { Id = 10, LanguageId = 1, SettingId = 4, Value = "30" },
            new() { Id = 11, LanguageId = 2, SettingId = 4, Value = "30" },
            new() { Id = 12, LanguageId = 3, SettingId = 4, Value = "30" },
        
            // FacebookLink
            new() { Id = 13, LanguageId = 1, SettingId = 5, Value = "https://facebook.com/example" },
            new() { Id = 14, LanguageId = 2, SettingId = 5, Value = "https://facebook.com/example" },
            new() { Id = 15, LanguageId = 3, SettingId = 5, Value = "https://facebook.com/example" },
        
            // InstagramLink
            new() { Id = 16, LanguageId = 1, SettingId = 6, Value = "https://instagram.com/example" },
            new() { Id = 17, LanguageId = 2, SettingId = 6, Value = "https://instagram.com/example" },
            new() { Id = 18, LanguageId = 3, SettingId = 6, Value = "https://instagram.com/example" },
        
            // TiktokLink
            new() { Id = 19, LanguageId = 1, SettingId = 7, Value = "https://tiktok.com/@example" },
            new() { Id = 20, LanguageId = 2, SettingId = 7, Value = "https://tiktok.com/@example" },
            new() { Id = 21, LanguageId = 3, SettingId = 7, Value = "https://tiktok.com/@example" },
        
            // FooterDescription
            new() { Id = 22, LanguageId = 1, SettingId = 8, Value = "Biz sizin uğurunuz üçün çalışırıq." },
            new() { Id = 23, LanguageId = 2, SettingId = 8, Value = "We work for your success." },
            new() { Id = 24, LanguageId = 3, SettingId = 8, Value = "Мы работаем для вашего успеха." },
        
            // PhoneNumber
            new() { Id = 25, LanguageId = 1, SettingId = 9, Value = "+994 51 000 00 00" },
            new() { Id = 26, LanguageId = 2, SettingId = 9, Value = "+994 51 000 00 00" },
            new() { Id = 27, LanguageId = 3, SettingId = 9, Value = "+994 51 000 00 00" },
        
            // Email
            new() { Id = 28, LanguageId = 1, SettingId = 10, Value = "info@example.com" },
            new() { Id = 29, LanguageId = 2, SettingId = 10, Value = "info@example.com" },
            new() { Id = 30, LanguageId = 3, SettingId = 10, Value = "info@example.com" },

            // WhatsappLink
            new() { Id = 31, LanguageId = 1, SettingId = 11, Value = "https://wa.me/994510000000" },
            new() { Id = 32, LanguageId = 2, SettingId = 11, Value = "https://wa.me/994510000000" },
            new() { Id = 33, LanguageId = 3, SettingId = 11, Value = "https://wa.me/994510000000" },

            // AboutTitle
            new() { Id = 34, LanguageId = 1, SettingId = 12, Value = "Haqqımızda" },
            new() { Id = 35, LanguageId = 2, SettingId = 12, Value = "About Us" },
            new() { Id = 36, LanguageId = 3, SettingId = 12, Value = "О нас" },

            // AboutDescription
            new() { Id = 37, LanguageId = 1, SettingId = 13, Value = "Biz sizin uğurunuz üçün çalışırıq. Bizimlə əlaqə saxlayın." },
            new() { Id = 38, LanguageId = 2, SettingId = 13, Value = "We work for your success. Contact us." },
            new() { Id = 39, LanguageId = 3, SettingId = 13, Value = "Мы работаем для вашего успеха. Свяжитесь с нами." },

            // ContactTitle
            new() { Id = 40, LanguageId = 1, SettingId = 14, Value = "Əlaqə" },
            new() { Id = 41, LanguageId = 2, SettingId = 14, Value = "Contact" },
            new() { Id = 42, LanguageId = 3, SettingId = 14, Value = "Контакт" },

            // ContactDescription
            new() { Id = 43, LanguageId = 1, SettingId = 15, Value = "Bizimlə əlaqə saxlayın və suallarınızı cavablandıraq." },
            new() { Id = 44, LanguageId = 2, SettingId = 15, Value = "Contact us and we will answer your questions." },
            new() { Id = 45, LanguageId = 3, SettingId = 15, Value = "Свяжитесь с нами, и мы ответим на ваши вопросы." },

            // FAQTitle
            new() { Id = 46, LanguageId = 1, SettingId = 16, Value = "Tez-tez verilən suallar" },
            new() { Id = 47, LanguageId = 2, SettingId = 16, Value = "Frequently Asked Questions" },
            new() { Id = 48, LanguageId = 3, SettingId = 16, Value = "Часто задаваемые вопросы" },

            // FAQDescription
            new() { Id = 49, LanguageId = 1, SettingId = 17, Value = "Sizdən tez-tez soruşulan sualların cavablarını burada tapa bilərsiniz." },
            new() { Id = 50, LanguageId = 2, SettingId = 17, Value = "You can find answers to frequently asked questions here." },
            new() { Id = 51, LanguageId = 3, SettingId = 17, Value = "Вы можете найти ответы на часто задаваемые вопросы здесь." },

            // Address
            new() { Id = 52, LanguageId = 1, SettingId = 18, Value = "Bakı, Azərbaycan" },
            new() { Id = 53, LanguageId = 2, SettingId = 18, Value = "Baku, Azerbaijan" },
            new() { Id = 54, LanguageId = 3, SettingId = 18, Value = "Баку, Азербайджан" },

            // HomeSection1Title
            new() { Id = 55, LanguageId = 1, SettingId = 19, Value = "Bizim Uğurumuz" },
            new() { Id = 56, LanguageId = 2, SettingId = 19, Value = "Our Success" },
            new() { Id = 57, LanguageId = 3, SettingId = 19, Value = "Наш успех" },

            // HomeSection2Title
            new() { Id = 61, LanguageId = 1, SettingId = 21, Value = "Bizim Servislərimiz" },
            new() { Id = 62, LanguageId = 2, SettingId = 21, Value = "Our Services" },
            new() { Id = 63, LanguageId = 3, SettingId = 21, Value = "Наши услуги" },

            // HomeSection2Description
            new() { Id = 64, LanguageId = 1, SettingId = 22, Value = "Biz müştərilərimizə ən yaxşı xidmətləri təqdim edirik." },
            new() { Id = 65, LanguageId = 2, SettingId = 22, Value = "We provide the best services to our customers." },
            new() { Id = 66, LanguageId = 3, SettingId = 22, Value = "Мы предоставляем лучшие услуги нашим клиентам." },

            // HomeSection3Title
            new() { Id = 67, LanguageId = 1, SettingId = 23, Value = "Müştəri Rəyləri" },
            new() { Id = 68, LanguageId = 2, SettingId = 23, Value = "Customer Reviews" },
            new() { Id = 69, LanguageId = 3, SettingId = 23, Value = "Отзывы клиентов" },

            // HomeSection3Description
            new() { Id = 70, LanguageId = 1, SettingId = 24, Value = "Müştərilərimizin rəyləri bizim üçün çox önəmlidir." },
            new() { Id = 71, LanguageId = 2, SettingId = 24, Value = "Customer reviews are very important to us." },
            new() { Id = 72, LanguageId = 3, SettingId = 24, Value = "Отзывы клиентов очень важны для нас." },

            // HomeSection4Title
            new() { Id = 73, LanguageId = 1, SettingId = 25, Value = "Əlaqə Forması" },
            new() { Id = 74, LanguageId = 2, SettingId = 25, Value = "Contact Form" },
            new() { Id = 75, LanguageId = 3, SettingId = 25, Value = "Контактная форма" },

            // HomeSection4Description
            new() { Id = 76, LanguageId = 1, SettingId = 26, Value = "Bizimlə əlaqə saxlamaq üçün aşağıdakı formu doldurun." },
            new() { Id = 77, LanguageId = 2, SettingId = 26, Value = "Fill out the form below to contact us." },
            new() { Id = 78, LanguageId = 3, SettingId = 26, Value = "Заполните форму ниже, чтобы связаться с нами." },

            // HomeSection5Title
            new() { Id = 79, LanguageId = 1, SettingId = 27, Value = "Əlaqə Məlumatları" },
            new() { Id = 80, LanguageId = 2, SettingId = 27, Value = "Contact Information" },
            new() { Id = 81, LanguageId = 3, SettingId = 27, Value = "Контактная информация" },

            // HomeSection5Description
            new() { Id = 82, LanguageId = 1, SettingId = 28, Value = "Bizimlə əlaqə saxlamaq üçün aşağıdakı məlumatlardan istifadə edin." },
            new() { Id = 83, LanguageId = 2, SettingId = 28, Value = "Use the information below to contact us." },
            new() { Id = 84, LanguageId = 3, SettingId = 28, Value = "Используйте информацию ниже, чтобы связаться с нами." },

            // ContactFormTitle
            new() { Id = 85, LanguageId = 1, SettingId = 29, Value = "Əlaqə Forması" },
            new() { Id = 86, LanguageId = 2, SettingId = 29, Value = "Contact Form" },
            new() { Id = 87, LanguageId = 3, SettingId = 29, Value = "Контактная форма" },

            // ContactFormDescription
            new() { Id = 88, LanguageId = 1, SettingId = 30, Value = "Bizimlə əlaqə saxlamaq üçün aşağıdakı formu doldurun." },
            new() { Id = 89, LanguageId = 2, SettingId = 30, Value = "Fill out the form below to contact us." },
            new() { Id = 90, LanguageId = 3, SettingId = 30, Value = "Заполните форму ниже, чтобы связаться с нами." }




        };

        builder.Entity<Setting>().HasData(settings);
        builder.Entity<SettingLanguage>().HasData(settingLanguages);
    }
}
