using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv4
{
    public class StringStatistics
    {
        public string Text { get; set; }

        public StringStatistics(string text)
        {
            this.Text = text;
        }

        public int WordsTotal()
        {
            char[] delimiters = { ' ', '\n' };
            
            return this.Text.Split(delimiters).Length;
        }

        public int RowsTotal()
        {
            return this.Text.Split('\n').Length;
        }

        public int SentencesTotal()
        {
            char[] delimiters = { '.', '!', '?' };
            string[] rows = this.Text.Replace("\n", "").Split(delimiters);
            int count = 0;
           
            for (int i = 0; i < rows.Length - 1; i++)
            {
                if (Char.IsUpper(rows[i].Trim()[0]))
                {
                    count++;
                }
            }

            return count;
        }

        public string[] LongestWords()
        {
            List<string> longestWords = new List<string>();
            char[] delimiters = { ' ', '\n', '!', '?', ',', '.', '(', ')' };
            string[] words = this.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int longest = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > longest)
                {
                    longestWords.Clear();
                    longestWords.Add(word);
                    longest = word.Length;
                }
                else if (word.Length == longest)
                {
                    longestWords.Add(word);
                }
            }

            return longestWords.ToArray();
        }

        public string[] ShortestWords()
        {
            List<string> shortestWords = new List<string>();
            char[] delimiters = { ' ', '\n', '!', '?', ',', '.', '(', ')' };
            string[] words = this.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int shortest = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length < shortest)
                {
                    shortestWords.Clear();
                    shortestWords.Add(word);
                    shortest = word.Length;
                }
                else if (word.Length == shortest)
                {
                    shortestWords.Add(word);
                }
            }

            return shortestWords.ToArray();
        }

        public string[] MostCommonWords()
        {
            char[] delimiters = { ' ', '\n', '!', '?', ',', '.', '(', ')' };
            string[] words = this.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            var wordGroups = words.GroupBy(word => word);
            int maxWordGroup = wordGroups.Max(wordGroup => wordGroup.Count());
            string[] mostCommonWords = wordGroups.Where(wordGroup => wordGroup.Count() == maxWordGroup).Select(wordGroup => wordGroup.Key).ToArray();

            return mostCommonWords;
        }

        public string[] SortedArray()
        {
            char[] delimiters = { ' ', '\n', '!', '?', ',', '.', '(', ')' };
            string[] words = this.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
 
            Array.Sort(words);

            return words;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
