using System.Drawing;
using CommandLine;
using Arguments = CommandLine.Parser;
using Out = Colorful.Console;

namespace Phonetic.Speller.Console
{
    internal sealed class Program
    {
        internal static int Main(string[] args) => 
            Arguments.Default.ParseArguments<Options>(args)
                .MapResult(options => Run(options), _ => 1);

        private static int Run(Options options)
        {
            PhoneticSpeller speller = new PhoneticSpeller();
            foreach(string word in options.Words)
            {
                Out.WriteLine($"Word Found:\t{word}", Color.Yellow);
                foreach((char character, string nato) in speller.GetSpelling(word))
                {
                    Out.Write($"{character}\t=>", Color.Green);
                    Out.WriteLine($"\t{nato}", Color.White);
                }
            }
            return 0;
        }
    }
}