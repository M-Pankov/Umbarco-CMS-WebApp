using System.Collections.Generic;
using System.Linq;
using Umbraco.Cms.Core.Models;

namespace Umbraco.V11.umbraco
{
    public static class LanguageExtensions
    {
        public static string GetLanguageFromIsoCode(IEnumerable<ILanguage> languages, string isoCode)
        {
            return languages.FirstOrDefault(l => l.IsoCode.ToLower() == isoCode.ToLower())?.CultureInfo?.TwoLetterISOLanguageName ?? isoCode;
        }
    }
}
