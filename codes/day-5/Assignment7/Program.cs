using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I love DotNet. I worked in dotnet
            Console.Write("Enter Sentence: ");
            string sentence = Console.ReadLine();
            CountFrequencyOfWords(sentence);
        }

        private static void CountFrequencyOfWords(string sentence)
        {
            //find out the separators and create an unique collection of separators
            HashSet<char> separators = new HashSet<char>();
            foreach (char ch in sentence)
            {
                if (!(char.IsLetter(ch) || char.IsDigit(ch)))
                {
                    separators.Add(ch);
                }
            }
            //foreach (char ch in separators)
            //{
            //    Console.WriteLine(ch == ' ' ? "space" : ch);
            //}

            //splitting the sentence
            string[] words = sentence.Split(separators.ToArray<char>(), StringSplitOptions.RemoveEmptyEntries);

            SortedList<string, int> counts = new SortedList<string, int>();
            foreach (string word in words)
            {
                if (counts.ContainsKey(word.ToLower()))
                {
                    counts[word.ToLower()] = counts[word.ToLower()] + 1;
                }
                else
                {
                    counts[word.ToLower()] = 1;
                }
            }
            foreach (KeyValuePair<string,int> keyValue in counts)
            {
                Console.WriteLine($"{keyValue.Key}:{keyValue.Value}");
            }
        }
    }
}
