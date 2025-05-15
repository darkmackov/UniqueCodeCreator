using System.Globalization;
using UniqueCodeCreator.Localization;

namespace UniqueCodeCreator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Get the user's current culture
            CultureInfo userCulture = CultureInfo.CurrentUICulture;
            string userLanguage = userCulture.TwoLetterISOLanguageName;

            Localizator localizator = new Localizator();

            if (!localizator.supportedLanguages.Contains(userLanguage))
            {
                // If the user's language is not supported, default to English
                userLanguage = "en";
            }
            localizator.ChangeLanguage(userLanguage);

            // Create the main form and set the language
            Form form = new FormMain();
            localizator.AutoUpdateTexts(form);

            Application.Run(form);
        }
    }
}