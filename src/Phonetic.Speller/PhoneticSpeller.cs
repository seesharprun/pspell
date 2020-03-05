using System.Collections.Generic;

namespace Phonetic.Speller
{
    public sealed class PhoneticSpeller : IPhoneticSpeller
    {
        public IEnumerable<(char, string)> GetSpelling(string word)
        {
            foreach(char character in word.Trim().ToUpper().ToCharArray())
            {
                string nato = "Not Found";
                PhoneticAlphabet.Alphabet.TryGetValue(character, out nato);
                yield return (character, nato);
            }
        }
    }
}