using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace P2FixAnAppDotNetCode.Models.Services
{
    /// <summary>
    /// Provides services method to manage the application language
    /// </summary>
    public class LanguageService : ILanguageService
    {
        /// <summary>
        /// Set the UI language
        /// </summary>
        public void ChangeUiLanguage(HttpContext context, string language)
        {
            string culture = SetCulture(language);
            UpdateCultureCookie(context, culture);
        }

        /// <summary>
        /// Set the culture
        /// </summary>
        public string SetCulture(string language)
        {
            string culture = "en"; // default to English

            if (string.IsNullOrEmpty(language))
            {
                return culture;
            }

            var normalized = language.Trim();
            var lower = normalized.ToLowerInvariant();
            // If the caller sends a culture code directly (e.g., "en", "fr", "wo" or "en-US"), accept it as-is
            if (normalized.Length <= 3 || normalized.Contains("-"))
            {
                return lower; // return normalized culture code in lowercase
            }

            // Map display language names (from the language selector) to culture codes
            switch (lower)
            {
                case "english":
                    culture = "en";
                    break;
                case "french":
                    culture = "fr";
                    break;
                case "spanish":
                    culture = "es";
                    break;
                case "wolof":
                    culture = "wo";
                    break;
                default:
                    culture = "en";
                    break;
            }

            return culture;
        }

        /// <summary>
        /// Update the culture cookie
        /// </summary>
        public void UpdateCultureCookie(HttpContext context, string culture)
        {
            context.Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)));
        }
    }
}
