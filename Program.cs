using System.Drawing;
using CommandLine;
using Arguments = CommandLine.Parser;
using Console = Colorful.Console;

namespace pspell
{
    internal sealed class Program
    {
        internal static int Main(string[] args) => 
            Arguments.Default.ParseArguments<Options>(args)
                .MapResult(options => Run(options), _ => 1);

        private static int Run(Options options)
        {
            foreach(string word in options.Words)
            {
                Console.WriteLine($"Word Found:\t{word}", Color.Yellow);
                foreach(char character in word.Trim().ToUpper().ToCharArray())
                {
                    string nato = "Not Found";
                    Phonetic.Alphabet.TryGetValue(character, out nato);
                    Console.Write($"{character}\t=>", Color.Green);
                    Console.WriteLine($"\t{nato}", Color.White);
                }
            }
            return 0;
        }
    }
}