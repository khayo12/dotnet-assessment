using System.Collections.Generic;
using System.Text;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            var charList1 = new List<char>();
            var charList2 = new List<char>();

            foreach (var c in word1.ToLower().Trim())
            {
                if (!charList1.Contains(c))
                {
                    charList1.Add(c);
                }
            }

            foreach (var c in word2.ToLower().Trim())
            {
                if (!charList2.Contains(c))
                {
                    charList2.Add(c);
                }
            }

            charList1.Sort();
            charList2.Sort();

            var a = new StringBuilder();
            var b = new StringBuilder();

            foreach (var c in charList1)
            {
                a.Append(c);
            }

            foreach (var c in charList2)
            {
                b.Append(c);
            }

            if (a.ToString() == b.ToString())
            {
                return true;
            }

            return false;
        }
    }
}
