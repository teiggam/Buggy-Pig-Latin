using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigLatin
{
    class TranslateController
    {

        //TranslateController was made to help translate sentences.
        //This splits sentences into words,
        //then translates each word and strings them back together
        //to output the fully translated sentence

        SpecialCharacter spec = new SpecialCharacter();

        public string GetWord(string input)
        {
            string newWords = "";
            string returnSentence = "placeholder";
            List<string> sentence = input.Split(new char[] { ' ' }).ToList();
            List<string> outputSentence = new List<string>();
            foreach (string w in sentence)
            {
                for (int i = 0; i < sentence.Count; i++)
                {
                    newWords = spec.ToPigLatin(w);
                }
                    outputSentence.Add(newWords);
                    returnSentence = String.Join(" ", outputSentence);

            }
            return returnSentence;
        }
    }
}
