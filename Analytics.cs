using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Letter_Counter;

namespace Letter_Counter
{
    public class Analytics
    {

        public int WordCount {  get; set; }
        public int LetterCount { get; set; }
        public int SentenceCount { get; set; }
        public string[] MostCommonWords { get; set; }
        public string[] MostCommonLetters { get; set; }

        List<string> TimesUsedWords = new List<string>();
        List<string> TimesUsedLetters = new List<string>();


        public string[] timesUsedWords;
        public string[] timesUsedLetters;

        public Analytics()
        {
            Parser parser = new Parser();
            this.WordCount = getWordCount(Parser.Words);
            this.LetterCount = getLetterCount(Parser.Letters);
            this.MostCommonWords= commonWords(Parser.Words);
            this.MostCommonLetters = commonLetters(Parser.Letters);
        }

        static void Analyze()
        {

        }

        private int getWordCount(string[] Input) 
        {
            int wordCount = Input.GetLength(0);
            return wordCount;
        }

        private int getLetterCount(char[] Input)
        {

            List<char> Letters = Input.ToList<char>();

            char space = ' ';

            Letters.RemoveAll(x => x == space);

            int letterCount = Letters.Count;
            return letterCount;
        }

        private string[] commonWords(string[] Input)
        {
           
            List<string> CommonWords = new List<string>();
            List<string> listOfWords = new List<string>();

            CommonWords = Input.ToList();

            var groups = CommonWords.GroupBy(x => x);
            foreach (var group in groups)
            {
                listOfWords.Add($"{group.Key}, ");
                TimesUsedWords.Add($"{group.Count().ToString()}, ");
            }

            timesUsedWords = TimesUsedWords.ToArray(); 

            return listOfWords.ToArray();

        }

        private string[] commonLetters(char[] Input)
        {

            List<char> CommonLetters = new List<char>();
            List<string> listOfLetters = new List<string>();

            CommonLetters = Input.ToList();

            var groups = CommonLetters.GroupBy(x => x);
            foreach(var group in groups)
            {
                listOfLetters.Add($"{group.Key}, ");
                TimesUsedLetters.Add($"{group.Count().ToString()}, ");
            }

            timesUsedLetters = TimesUsedLetters.ToArray();

            return listOfLetters.ToArray();
        }

    }

}
