using System;

namespace cv5
{
    abstract public class Car
    {
        private CarRadio radio;
        public enum FuelType
        {
            Petrol,
            Diesel
        }
        public double TankSize { get; protected set; }
        public double TankState { get; set; }
        public FuelType Fuel { get; protected set; }

        public Car(double tankSize, FuelType fuel, double tankState = 0)
        {
            this.TankSize = tankSize;
            this.TankState = tankState;
            this.Fuel = fuel;
            this.radio = new CarRadio();
        }

        public void Refuel(FuelType fuel, double amount)
        {
            if (this.Fuel != fuel)
            {
                throw new ArgumentException("Fuel is not of the same type");
            }
            else if (this.TankState + amount > this.TankSize)
            {
                throw new ArgumentOutOfRangeException("The car tank overflowed");
            }

            this.TankState += amount;
        }

        public void ToggleRadio()
        {
            this.radio.Status = !this.radio.Status;
        }

        public void SetPreset(int index, double frequency)
        {
            this.radio.SetPreset(index, frequency);
        }

        public void TuneRadio(int index)
        {
            this.radio.TuneRadio(index);
        }

        public string ShowRadio()
        {
            return this.radio.ToString();
        }

        public override string ToString()
        {
            return String.Format("Tank state: {0}/{1}, Fuel type: {2}, {3}.", this.TankState, this.TankSize, this.Fuel, this.radio.ToString());
        }
    }
}
