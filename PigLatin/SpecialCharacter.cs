using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class SpecialCharacter : ITranslate
    {
        //Word is first evaluated for special characters

        public string ToPigLatin(string word)
        {
            Vowels aei = new Vowels();
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        return word;
                    }
                }
            }
            //if the word does not have a special character,
            //it is then sent to check for vowels and vowel location
            return aei.ToPigLatin(word);
        }
    }
}
