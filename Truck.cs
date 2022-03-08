using System;

namespace cv5
{
    public class Truck : Car
    {
        private double load;

        public double LoadLimit { get; private set; }

        public double Load
        {
            get { return this.load; }
            set
            {
                this.load = this.CheckLoad(value);
            }
        }

        public Truck(double tankSize, FuelType fuel, double loadLimit, double tankState = 0, double load = 0) : base(tankSize, fuel, tankState)
        {
            this.LoadLimit = loadLimit;
            this.Load = load;
        }
        private double CheckLoad(double load)
        {
            if (load > this.LoadLimit)
            {
                throw new ArgumentOutOfRangeException("Truck load limit exceeded");

            }

            return load;
        }

        public override string ToString()
        {
            return String.Format("{0} Truck load: {1}/{2}.", base.ToString(), this.Load, this.LoadLimit);
        }
    }
}
