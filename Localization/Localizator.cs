using System.Globalization;

namespace UniqueCodeCreator.Localization
{
    public class Localizator
    {
        public readonly string[] supportedLanguages = { "en", "cs" };
        public string currentLanguage = "en";

        public void ChangeLanguage(string language)
        {
            if (supportedLanguages.Contains(language))
            {
                currentLanguage = language;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            }
            else
            {
                throw new ArgumentException($"Language '{language}' is not supported.");
            }
        }

        public void ChangeLanguage(string language, Control control)
        {
            ChangeLanguage(language);
            AutoUpdateTexts(control);
        }

        public void AutoUpdateTexts(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (!string.IsNullOrEmpty(c.Name))
                {
                    var res = Localization.ResourceManager.GetString(c.Name);
                    if (!string.IsNullOrEmpty(res))
                        c.Text = res;
                }
                if (c.HasChildren)
                    AutoUpdateTexts(c);
            }
        }
    }
}
