using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace cv8
{
    public class TemperatureArchive
    {
        private SortedDictionary<int, Temperature> _archive;

        private const string Directory = "C:\\Users\\lazar\\Downloads\\cv8\\cv8";
        private const string Input = "input.txt";
        private const string Output = "output.txt";

        public TemperatureArchive()
        {
            this._archive = new SortedDictionary<int, Temperature>();
        }

        public void Load()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(Directory, Input)))
                {
                    string line;
                    List<double> temperatures = new List<double>();

                    while ((line = sr.ReadLine()) != null)
                    {
                        line.Trim().Replace(" ", "");
                        temperatures = new List<double>();

                        string[] splitter = line.Split(new Char[] { ':', ';' });

                        for (int i = 1; i < splitter.Length; i++)
                        {
                            temperatures.Add(double.Parse(splitter[i], System.Globalization.CultureInfo.GetCultureInfo("cs-CZ").NumberFormat));
                        }

                        this._archive.Add(Convert.ToInt32(splitter[0]), new Temperature(Convert.ToInt32(splitter[0]), temperatures));
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Save()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(Directory, Output)))
                {
                    foreach (Temperature temp in this._archive.Values)
                    {
                        sw.Write(String.Format("{0}: {1}\n", temp.Year, String.Join("; ", temp.Temperatures.Select(x => x.ToString("N1", System.Globalization.CultureInfo.GetCultureInfo("cs-CZ").NumberFormat)))));
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Calibration(double value)
        {
            foreach (Temperature temp in this._archive.Values)
            {
                temp.Calibration(value);
            }
        }

        public Temperature Find(int year)
        {
            return this._archive.FirstOrDefault(x => x.Key == year).Value;
        }

        public string YearAverage()
        {
            return String.Join("", this._archive.Values.Select(x => String.Format("{0}: {1:N1}\n", x.Year, x.Average)));
        }

        public string MonthAverage()
        {
            StringBuilder output = new StringBuilder();
            List<double> averages = new List<double>();

            return String.Join("", Enumerable.Range(1, 12)
                .Select(month => new KeyValuePair<int, double>(month, this._archive.Select(x => x.Value.Temperatures.ElementAt(month - 1)).Average()))
                .Select(x => String.Format("{0}: {1:N1}\n", x.Key, x.Value)));
        }
        public string Print()
        {
            StringBuilder output = new StringBuilder();

            foreach (Temperature temp in this._archive.Values)
            {
                output = output.AppendLine(String.Format("{0}", temp));
            }

            return output.ToString();
        }
    }
}
