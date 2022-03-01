using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Toto je retezec predstavovany nekolika radky,\n"
                + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                + "posledni veta!";

            StringStatistics textStats = new StringStatistics(text);

            Console.WriteLine(textStats);
            Console.WriteLine();

            Console.WriteLine("Words total: {0}", textStats.WordsTotal());
            Console.WriteLine("Rows total: {0}", textStats.RowsTotal());
            Console.WriteLine("Sentences total: {0}", textStats.SentencesTotal());
            Console.WriteLine("Longest words: {0}", string.Join(", ", textStats.LongestWords()));
            Console.WriteLine("Shortest words: {0}", string.Join(", ", textStats.ShortestWords()));
            Console.WriteLine("Most common words: {0}", string.Join(", ", textStats.MostCommonWords()));
            Console.WriteLine("Sorted array: {0}" , string.Join(", ", textStats.SortedArray()));

            Console.ReadLine();
        }
    }
}
