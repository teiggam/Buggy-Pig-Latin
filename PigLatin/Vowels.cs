using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigLatin
{
    class Vowels : ITranslate
    {

        public bool IsVowel(char c)
        {

            //Needed to change vowel.Contains to see if the word contains vowels.
            char[] vowel = { 'a', 'e', 'i', 'o', 'u' };

            return vowel.Contains(c);

        }

        public string ToPigLatin(string word)
        {
            bool noVowels = true;
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    noVowels = false;
                }
            }
            if (noVowels)
            {
                return word;
            }

            Consonants bcd = new Consonants();
            char firstLetter = word[0];
            string output = "placeholder";
            if (IsVowel(firstLetter) == true)
            {

                //changed to "way" not "ay" for adding to the end of words that start with a vowel
                output = word + "way";
                return output;
            }

            //if the word does not start with a vowel,
            //it is sent to the Consonants translation.
            return bcd.ToPigLatin(word);

        }
    }
}
