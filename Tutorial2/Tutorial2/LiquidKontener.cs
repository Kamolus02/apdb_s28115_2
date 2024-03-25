using System;
using System.Net.NetworkInformation;
using Tutorial2.Properties;

namespace Tutorial2
{
    public class LiquidKontener : Kontener, IHazardNotifier
    {

        public bool isHazardous { get; }
        public LiquidKontener(double weight, double height, double selfWeight, double depth, double maxWeight, bool isHazardous) : base(weight, height, selfWeight, depth, maxWeight)
        {
            this.isHazardous = isHazardous;
        }


        public override void Load(double weight)
        {
            if (isHazardous && selfWeight + weight > maxWeight*0.5)
            {
                throw new InvalidOperationException(
                    "You cannot load hazardous liquid over 50% of maximum weight of container ");
            }

            if (!isHazardous && selfWeight + weight > maxWeight*0.9)
            {
                throw new InvalidOperationException("You cannot load over 90% of maximum weight of container");
            }
            
            base.Load(weight);
        }

        public void NotifyDanger(string serialNumber)
        {
            Console.Write("Dangerous incident detected in " + serialNumber);
        }
    }
}