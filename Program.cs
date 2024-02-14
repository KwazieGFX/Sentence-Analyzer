using System;

namespace Letter_Counter
{

    class Program
    {

        //input and variables created by input
        public static string? input;
        //Arrays input will be split into
        public static char[] LettersInInput;
        public static char[] Alphabet;
        public static int[] Numbers;
        public static string[] Words;

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Passage Data Analytics");
            Console.WriteLine("-----------------------");
            Console.WriteLine("please input your passage.....");
            Console.WriteLine("Set Window size to fullscreen for best readability of results, if your input is rather long");

            input = Console.ReadLine();
            Run(input);
        }

        static void Run(string Input)
        {
            Console.Clear();

            Analytics analytics = new Analytics();

            Console.WriteLine($"there are {analytics.WordCount} words");
            Console.WriteLine($"there are {analytics.LetterCount} letters");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("WORDS AND THEIR FREQUENCY");
            Console.WriteLine("-------------------------------------------------------------");

            int index = 0;

            foreach (var set in analytics.MostCommonWords)
            {
                Console.Write(set);

                Console.Write($" Times Used: {analytics.timesUsedWords[index]}");
                Console.WriteLine(" ");

                index++;
            }

            index = 0;

            Console.WriteLine("END OF WORD LIST");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("LETTERS AND THEIR FREQUENCY");

            foreach(var set in analytics.MostCommonLetters)
            {
                Console.Write(set);
                Console.Write($" Times Used: {analytics.timesUsedLetters[index]}");
                Console.WriteLine(" ");

                index++;

            }

        }

    }


}