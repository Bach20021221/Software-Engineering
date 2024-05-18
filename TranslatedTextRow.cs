// Copyright © 2020 Andrew Vardeman.  Published under the MIT license.
// See license.txt in the AzureMultiTranslator distribution or repository for the
// full text of the license.

namespace AzureMultiTranslator
{
    public class TranslatedTextRow
    {
        public bool Translate { get; set; } = true;

        public string Language { get; set; } = "";

        public string TranslatedText { get; set; } = "";

        public string BackTranslatedText { get; set; } = "";

        public string Copy => "Copy";

        public string Remove => "X";

        public TranslatedTextRow(string language)
        {
            Language = language;
        }
    }
}
