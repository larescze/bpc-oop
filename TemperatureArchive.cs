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

        private const string Directory = "PUT_YOUR_ABSOLUTE_PATH_HERE";
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
                        temperatures.Clear();
                        string[] splitter = line.Split(new Char[] { ':', ';' });

                        for (int i = 1; i < splitter.Length; i++)
                        {
                            temperatures.Add(Convert.ToDouble(splitter[i]));
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
                        sw.Write(String.Format("{0}: {1}", temp.Year, String.Join("; ", temp.Temperatures.Select(x => string.Format("{0:N1}", x))) + "\n"));
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
            if (this._archive.TryGetValue(year, out Temperature value))
            {
                return value;
            }

            return null;
        }

        public string YearAverage()
        {
            StringBuilder output = new StringBuilder();

            foreach (Temperature temp in this._archive.Values)
            {
                output = output.AppendLine(String.Format("{0}: {1:N1}", temp.Year, temp.Average));
            }

            return output.ToString();
        }

        public string MonthAverage()
        {
            StringBuilder output = new StringBuilder();
            List<double> averages = new List<double>();

            double average;
            int count;

            for (int i = 0; i < this._archive.FirstOrDefault().Value.Temperatures.Count(); i++)
            {
                average = 0;
                count = 0;

                foreach (Temperature temp in this._archive.Values)
                {
                    average += temp.Temperatures[i];
                    count++;
                }

                averages.Add(average / count);
            }

            output = output.AppendLine(String.Join("", averages.Select((x, i) => string.Format("{0}: {1:N1}\n", ++i, x))));

            return output.ToString();
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
