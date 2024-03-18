using System.Net.NetworkInformation;

namespace Tutorial2
{
    public class LiquidKontener : Kontener
    {
        public LiquidKontener(double weight, double height, double selfWeight, double depth, double maxWeight) : base(weight, height, selfWeight, depth, maxWeight)
        {
        }
    }
}