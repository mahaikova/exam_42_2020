using System;
using System.Collections.Generic;

namespace Anagrams
{
    public class Program
    {
        public static Dictionary<char, int> ConvertStringToLettersDictionary(string str)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char chr in str)
            {
                if (letters.ContainsKey(chr))
                {
                    letters[chr]++;
                }
                else
                {
                    letters.Add(chr, 1);
                }
            }

            return letters;
        }

        public static string Anagrams(string firstWord, string secondWord)
        {
            if(firstWord.Length != secondWord.Length)
            {
                return "Слова не равной длинны";
            }

            int result = 0;
            Dictionary<char, int> letters1 = ConvertStringToLettersDictionary(firstWord.ToLower());
            Dictionary<char, int> letters2 = ConvertStringToLettersDictionary(secondWord.ToLower());

            int stringLength = firstWord.Length;

            foreach (char chr in letters2.Keys)
            {
                if(letters1.ContainsKey(chr))
                {
                    if(letters1[chr] != letters2[chr])
                    {
                        stringLength += letters2[chr] - letters1[chr];
                        if(stringLength == firstWord.Length)
                        {
                            result += Math.Abs(letters2[chr] - letters1[chr]);
                        }
                    }
                }
                else
                {
                    result += letters2[chr];
                }
            }

            if(result == 0)
            {
                return "Данные слова уже являются анаграммами";
            }

            return $"Следует заменить {result} букв(-ы)";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Anagrams("насос", "сосна"));
        }
    }
}
