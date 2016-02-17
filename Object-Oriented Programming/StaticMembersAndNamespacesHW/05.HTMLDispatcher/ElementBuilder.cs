using System;
using System.Collections.Generic;

namespace HTMLDispatcher
{
    public class ElementBuilder
    {
        private string tag;
        private List<string[]> attributes = new List<string[]>();
        private string content;

        public ElementBuilder(string tag)
        {
            Tag = tag;
        }

        public string Tag
        {
            get { return tag; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Tag cannot be null or empty !");
                }
                tag = value;
            }
        }

        public static string operator *(ElementBuilder element, int num)
        {
            if (num < 1)
            {
                throw new ArgumentOutOfRangeException("There must be atleast one element !");
            }

            string output = string.Empty;
            string htmlElement = element.ToString();

            for (int i = 0; i < num; i++)
            {
                output += htmlElement;
            }

            return output;
        }

        public void AddAttribute(string attribute, string value)
        {
            string[] temp = new string[2];
            temp[0] = attribute;
            temp[1] = value;
            attributes.Add(temp);
        }

        public void AddContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentNullException("Content cannot be null !");
            }
            this.content = content;
        }

        public override string ToString()
        {
            string output = "<" + tag;

            if (attributes.Count > 0)
            {
                foreach (string[] attribute in attributes)
                {
                    output += " " + attribute[0] + "=\"" + attribute[1] + "\"";
                }
            }
            else
            {
                output += ">";
            }

            output += content + "</" + tag + ">";
            return output;
        }
    }
}