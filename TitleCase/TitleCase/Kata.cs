using System;
using System.Linq;

namespace TitleCase
{
    public class Kata
    {
        public static string TitleCase (string title, string minorWords="")
        {
            string[] words = string.IsNullOrEmpty(minorWords) ? new string[] { "" } : minorWords.Split(' ').Select(x => x.ToLower()).ToArray();
            string[] titles = title.Split(' ');
            titles[0] = titles[0].Length > 1 ? Capitalize(titles[0]) : titles[0].ToUpper();
            
            for (int i = 1; i < titles.Length; i++)
            {
                if (words.Contains(titles[i].ToLower()))
                    titles[i] = titles[i].ToLower();
                else
                    titles[i] = Capitalize(titles[i]);
            }
            return string.Join(" ", titles);
        }

        public static string Capitalize (string word) => Char.ToUpper(word[0]) + word.Substring(1).ToLower();
    }
}
