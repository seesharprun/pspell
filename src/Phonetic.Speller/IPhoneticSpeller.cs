using System.Collections.Generic;

namespace Phonetic.Speller
{
    public interface IPhoneticSpeller
    {
        IEnumerable<(char, string)> GetSpelling(string word);
    }
}