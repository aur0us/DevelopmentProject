using System.Text.RegularExpressions;

namespace HTMLProcessor.Service
{
    public class HTMLParser
    {
        public string ProcessHTML(string inputHTML, string searchString, string replacementString)
        {
            string pattern = Regex.Escape(searchString);
            return Regex.Replace(inputHTML, pattern, replacementString);
        }
    }
}