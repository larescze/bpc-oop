using System;
using System.Collections.Generic;
using System.Linq;

namespace cv8
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<double> temps = new List<double>();
                temps.AddRange(new double[] { 4, 6, 8, -2, 1, 7, 9, 14, 20, 2, 3, 1 });
                Temperature temp2022 = new Temperature(2022, temps);

                Console.WriteLine(temp2022);
                Console.WriteLine("Min: {0}", temp2022.Min);
                Console.WriteLine("Max: {0}", temp2022.Max);
                Console.WriteLine("Average: {0:N1}", temp2022.Average);
                Console.WriteLine();

                TemperatureArchive archive = new TemperatureArchive();

                archive.Load();

                Console.WriteLine("Archive");
                Console.WriteLine(archive.Print());

                Console.WriteLine("Calibration");
                archive.Calibration(-0.1);
                Console.WriteLine(archive.Print());

                Console.WriteLine("Find 2010");
                Console.WriteLine(archive.Find(2010));
                Console.WriteLine();

                Console.WriteLine("Year average");
                Console.WriteLine(archive.YearAverage());

                Console.WriteLine("Month average");
                Console.WriteLine(archive.MonthAverage());

                archive.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
