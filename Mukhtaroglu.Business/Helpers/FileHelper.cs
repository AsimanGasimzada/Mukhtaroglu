using Microsoft.AspNetCore.Http;
using Mukhtaroglu.Core.Abstractions;

namespace Mukhtaroglu.Business.Helpers;
internal static class FileHelper
{
    public static string GetFileName(string fileName)
    {
        var fileExtension = Path.GetExtension(fileName);
        var newFileName = $"{Guid.NewGuid()}{fileExtension}";
        return newFileName;
    }

    public static string GetFilePath(string fileName, string folderName)
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", folderName, fileName);
        return filePath;
    }

    public static async Task<string> CreateFileAsync(this IFormFile file, string folderName)
    {
        var fileName = GetFileName(file.FileName);
        var filePath = GetFilePath(fileName, folderName);

        using (var stream = new FileStream(filePath, FileMode.Create))

            await file.CopyToAsync(stream).ContinueWith(_ => fileName);

        return fileName;
    }

    public static bool CheckSize(this IFormFile file, int maxSize)
                                                    => file.Length <= maxSize * 1024 * 1024;

    public static bool CheckType(this IFormFile file, string type = "image")
                                                    => file.ContentType.Contains(type);
}


public class LanguageHelper
{
    public static void CheckLanguageId(ref Languages language)
    {
        foreach (var l in Enum.GetNames(typeof(Languages)))
        {
            if (language.ToString() == l)
                return;
        }

        language = Languages.Azerbaijani;
    }
    public static bool CheckLanguageId(int id)
    {
        foreach (var l in Enum.GetValues(typeof(Languages)))
        {

            if (id == (int)l)
                return true;
        }

        return false;
    }

    public static bool CheckLanguageItems(IEnumerable<int> languageIds)
    {
        if (languageIds.Distinct().Count() != languageIds.Count())
            return false;

        foreach (var id in languageIds)
        {
            var isExistLanguage = CheckLanguageId(id);

            if (!isExistLanguage)
                return false;
        }

        return true;
    }

}
