using System.Collections.Generic;

namespace pspell
{
    public static class Phonetic
    {
        public static Dictionary<char, string> Alphabet { get; } = new Dictionary<char, string>
        {
            { 'A', "Alfa" },
            { 'B', "Bravo" },
            { 'C', "Charlie" },
            { 'D', "Delta" },
            { 'E', "Echo" },
            { 'F', "Foxtrot" },
            { 'G', "Golf" },
            { 'H', "Hotel" },
            { 'I', "India" },
            { 'J', "Juliett" },
            { 'K', "Kilo" },
            { 'L', "Lima" },
            { 'M', "Mike" },
            { 'N', "November" },
            { 'O', "Oscar" },
            { 'P', "Papa" },
            { 'Q', "Quebec" },
            { 'R', "Romeo" },
            { 'S', "Sierra" },
            { 'T', "Tango" },
            { 'U', "Uniform" },
            { 'V', "Victor" },
            { 'W', "Whiskey" },
            { 'X', "X-ray" },
            { 'Y', "Yankee" },
            { 'Z', "Zulu" }
        };
    }
}