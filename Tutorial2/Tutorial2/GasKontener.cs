namespace Tutorial2
{
    public class GasKontener : Kontener
    {
        
        public double Pressure { get;  }
        public GasKontener(double weight, double height, double selfWeight, double depth, double maxWeight, double pressure) : base(weight, height, selfWeight, depth, maxWeight)
        {
            Pressure = pressure;
        }
    }
}