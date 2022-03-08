using System;

namespace cv5
{
    public class PassengerCar : Car
    {
        private int passengers;
        public int Passengers
        {
            get { return this.passengers; }
            set
            {
                this.passengers = this.CheckPassengers(value);
            }
        }
        public int PassengerLimit { get; private set; }

        public PassengerCar(double tankSize, FuelType fuel, int passengerLimit, double tankState = 0, int passengers = 0) : base(tankSize, fuel, tankState)
        {
            this.PassengerLimit = passengerLimit;
            this.Passengers = passengers;
        }

        private int CheckPassengers(int passengers)
        {
            if (passengers > this.PassengerLimit)
            {
                throw new ArgumentOutOfRangeException("Number of passengers is out of limit");
            }

            return passengers;
        }

        public override string ToString()
        {
            return String.Format("{0} Passengers: {1}/{2}.", base.ToString(), this.Passengers, this.PassengerLimit);
        }
    }
}
