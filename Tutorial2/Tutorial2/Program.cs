using System;

namespace Tutorial2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            KontenerShip kontenerShip = new KontenerShip("ship01",100,2,200);
            GasKontener gasKontener = new GasKontener(200, 4, 20, 3, 220, 1);
            kontenerShip.LoadKontener(gasKontener);
            gasKontener.UnLoad();
            gasKontener.Load(200);
        }
    }
}