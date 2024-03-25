using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Tutorial2
{
    public class KontenerShip
    {
        public string Name { get; }
        public  double MaxSpeed { get; }
        public int MaxKontener { get; }
        public double MaxWeight { get; }
        private List<Kontener> konteners = new List<Kontener>();

        public KontenerShip(string name, double maxSpeed, int maxKontener, double maxWeight)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            MaxKontener = maxKontener;
            MaxWeight = maxWeight;
        }

        public void LoadKontener(Kontener kontener)
        {
            if (konteners.Count >= MaxKontener)
            {
                throw new InvalidOperationException("Maximum capacity reached");
            }

            if (TotalWeight() + kontener.weight + kontener.selfWeight > MaxWeight)
            {
                throw new InvalidOperationException("Too heavy!");
            }
            
            konteners.Add(kontener);
        }

        public void UnloadKontener(Kontener kontener)
        {
            konteners.Remove(kontener);
        }
        

        public double TotalWeight()
        {
            double totalWeight = 0;
            foreach (var x in konteners)
            {
                totalWeight += x.weight;
            }

            return totalWeight;
        }

        public void ListOfKonteners()
        {
            Console.WriteLine("List of containers on "+ Name);
            foreach (var x in konteners)
            {
                Console.WriteLine(x.serialNumber);
            }
        }
    }
}