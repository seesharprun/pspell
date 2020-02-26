using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace pspell
{
    internal sealed class Options
    {
        [Value(1, Min = 1, HelpText = "List of words.")]
        public IEnumerable<string> Words { get; set; }

        [Usage(ApplicationAlias = "pspell")]
        public static IEnumerable<Example> Examples
        {
            get => new List<Example>() {
                new Example(
                    "Translate a list of words to the NATO phonetic alphabet",
                    new Options {
                        Words = new List<string> { "EXAMPLE", "WORDS" }
                    }
                )
            };
        }
    }
}