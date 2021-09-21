using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class Consonants : ITranslate
    {
        public string ToPigLatin(string word)
        {
            string output = "placeholder";
            Vowels aei = new Vowels();

            int vowelIndex = -1;
            //Handle going through all the consonants
            for (int i = 0; i <= word.Length; i++)
            {
                if (aei.IsVowel(word[i]) == true)
                {
                    vowelIndex = i;
                    break;
                }
            }
           
            string sub = word.Substring(vowelIndex);
            string postFix = word.Substring(0, vowelIndex);

            output = sub + postFix + "ay";
            return output;
        }

    }
}
