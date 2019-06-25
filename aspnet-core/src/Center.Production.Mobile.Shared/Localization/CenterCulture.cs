using System;

namespace Center.Production.Localization
{
    /// <summary>
    /// Helper class for splitting locales like
    ///   iOS: ms_MY, gsw_CH
    ///   Android: in-ID
    /// into parts so we can create a .NET culture (or fallback culture)
    /// </summary>
    public class CenterCulture
    {
        public string CenterString { get; }
        public string LanguageCode { get; }
        public string LocaleCode { get; }

        public CenterCulture(string CenterCultureString)
        {
            if (string.IsNullOrEmpty(CenterCultureString))
            {
                throw new ArgumentException("Expected culture identifier", nameof(CenterCultureString));
            }

            CenterString = CenterCultureString.Replace("_", "-"); // .NET expects dash, not underscore
            var dashIndex = CenterString.IndexOf("-", StringComparison.Ordinal);
            if (dashIndex > 0)
            {
                var parts = CenterString.Split('-');
                LanguageCode = parts[0];
                LocaleCode = parts[1];
            }
            else
            {
                LanguageCode = CenterString;
                LocaleCode = "";
            }
        }

        public override string ToString()
        {
            return CenterString;
        }
    }
}