using System;
using System.Collections.Generic;
using System.Linq;

namespace cv8
{
    public class Temperature
    {
        public int Year { get; set; }
        private List<double> temperatures;
        public List<double> Temperatures
        {
            get
            {
                return this.temperatures;
            }
            private set
            {
                this.temperatures = value;
            }
        }
        public double Min
        {
            get
            {
                return this.temperatures.Min();
            }
        }
        public double Max
        {
            get
            {
                return this.temperatures.Max();
            }
        }
        public double Average
        {
            get
            {
                return this.temperatures.Average();
            }
        }

        public Temperature(int year)
        {
            this.Year = year;
            this.Temperatures = new List<double>();
        }

        public Temperature(int year, List<double> temperature)
        {
            this.Year = year;
            this.Temperatures = temperature;
        }

        public void Add(double temperature)
        {
            this.temperatures.Add(temperature);
        }

        public void Calibration(double value)
        {
            this.temperatures = this.temperatures.Select(x => x + value).ToList();
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", this.Year, String.Join(" ", this.temperatures.Select(x => string.Format(" {0:N1} ", x))));
        }
    }
}
