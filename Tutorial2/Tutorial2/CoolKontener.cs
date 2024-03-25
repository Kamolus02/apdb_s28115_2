namespace Tutorial2.Properties
{
    public class CoolKontener : Kontener, IRefigeratedKontener
    {
        public string ProductType { get; }
        public double RequiredTemp { get; }
        public CoolKontener(double weight, double height, double selfWeight, double depth, double maxWeight, string productType, double requiredTemp) : base(weight, height, selfWeight, depth, maxWeight)
        {
            ProductType = productType;
            RequiredTemp = requiredTemp;
        }
    }
}