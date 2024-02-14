using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Letter_Counter;

namespace Letter_Counter
{
    public class Parser
    {

        public static string[] Words { get; set; }
        public static char[] Letters { get; set; }
        public static string? input = Program.input;

        public Parser() {

            Words = ParseWords(Words, input);
            Letters = ParseLetters(Letters, input);
        }
        static string[] ParseWords(string[] words, string input)
        {
            char[] splitters = [' ', '.', ',', '?', '!', '$', '%', '"'];
            words = input.Split(splitters);
            return words;
        }

        static char[] ParseLetters(char[] letters, string input) {
            char[] splitters = [' ', '.', ',', '?', '!', '$', '%', '"', ];

            input.Split(splitters, StringSplitOptions.RemoveEmptyEntries);

            letters = input.ToCharArray();

            return letters;
        }

        static string[] ParseSentences(string[] sentences, string input)
        {

            return sentences;
        }

    }
}
