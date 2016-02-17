using System;

namespace HTMLDispatcher
{
    public static class HTMLDispatcher
    {
        public static string CreateImage(string imgSrc, string alt, string title)
        {
            string output;

            if (string.IsNullOrWhiteSpace(imgSrc) || string.IsNullOrWhiteSpace(alt) || string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException("Your content cannot be null !");
            }

            return output = string.Format("<img src=\"{0}\" alt=\"{1}\" title=\"{2}\"/>",
                imgSrc, alt, title);
        }

        public static string CreateURL(string url, string title, string text)
        {
            string output;

            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException("Your content cannot be null !");
            }

            return output = string.Format("<a href=\"{0}\" title=\"{1}\">{2}</a>",
                url, title, text);
        }

        public static string CreateInput(string inputType, string name, string value)
        {
            string output;

            if (string.IsNullOrWhiteSpace(inputType) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Your content cannot be null !");
            }

            return output = string.Format("<input type=\"{0}\" name=\"{1}\" value=\"{2}\"/>",
                inputType, name, value);
        }
    }
}