namespace cv12_WPF
{
    public class CalculationData
    {
        public string Operation { get; set; }
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }

        public CalculationData(string operation, double operand1, double operand2)
        {
            this.Operation = operation;
            this.Operand1 = operand1;
            this.Operand2 = operand2;
        }
    }
}
