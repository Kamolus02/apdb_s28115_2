using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Tutorial2
{
    public abstract class Kontener
    {
        private static int counter = 0;
        protected Kontener(double weight, double height, double selfWeight, double depth, double maxWeight)
        {
            this.weight = weight;
            this.height = height;
            this.selfWeight = selfWeight;
            this.depth = depth;
            this.maxWeight = maxWeight;
        }
        public double weight { get; set; }
        public double height { get; }
        public double selfWeight { get; }
        public double depth { get; }
        public double maxWeight { get; }
        public string serialNumber { get; }



        private string GenerateSerialNumber()
        {
            counter++;
            return "KON-" + GetType().Name[0] + "-" + counter;
        }
        
        

        public void UnLoad()
        {
            weight = 0;
        }

        public virtual void Load(double weight)
        {
            if (maxWeight < weight + selfWeight)
            {
                throw new OverfillException("Container weight can't handle this weight");
            }
            else
            {
                this.weight += weight;
            }
        }
    }
}