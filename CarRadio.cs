using System;
using System.Collections.Generic;

namespace cv5
{
    public class CarRadio
    {
        private Dictionary<int, double> preset;
        public bool Status { get; set; }
        public double Frequency { get; set; }

        public CarRadio(bool status = false, double frequency = 0.00)
        {
            this.Status = status;
            this.Frequency = frequency;
            this.preset = new Dictionary<int, double>();
        }

        public void SetPreset(int index, double frequency)
        {
            if (!this.preset.ContainsKey(index))
            {
                this.preset.Add(index, frequency);
            }
            else
            {
                this.preset[index] = frequency;
            }
        }

        public void TuneRadio(int index)
        {
            if (this.preset.TryGetValue(index, out double value))
            {
                this.Frequency = value;
            }
            else
            {
                throw new ArgumentException("Not in the radio preset");
            }
        }

        public override string ToString()
        {
            if (this.Status)
            {
                return String.Format("Radio frequency: {0, 0:N2}", this.Frequency);
            }

            return "Radio is turned off";
        }
    }
}
