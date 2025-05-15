using Mukhtaroglu.Core.Enums;

namespace Mukhtaroglu.Business.Services.Abstractions;
public interface ILanguageService
{
    void SelectCulture(string culture);
    string GetSelectedCulture();
    Languages SelectedLanguage { get; }
}
