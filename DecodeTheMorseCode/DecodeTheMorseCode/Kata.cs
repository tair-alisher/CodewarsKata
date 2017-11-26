using System;

namespace DecodeTheMorseCode
{
    public class Kata
    {
        public static string Decode (string morseCode)
        {
            string result = "";
            string[] morseCodeWords = morseCode.Split(new[] { "  " }, StringSplitOptions.None);

            foreach (string morseCodeWord in morseCodeWords)
            {
                string[] morseCodeLetters = morseCodeWord.Split(' ');
                foreach (string morseCodeLetter in morseCodeLetters)
                    result += MorseCode.Get(morseCodeLetter);
                result += ' ';
            }

            return result.Trim();
        }
    }
}
