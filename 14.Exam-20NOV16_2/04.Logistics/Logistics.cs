using System;

namespace _08.Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int numberOfShipments = int.Parse(Console.ReadLine());
            int cargoBus = 0;
            int cargoTruck = 0;
            int cargoTrain = 0;
            double busCargoPriceTon = 200;
            double truckCargoPriceTon = 175;
            double trainCargoPriceTon = 120;
            double averagePrice = 0;
            double totalWeight = 0;

            for (int i = 0; i < numberOfShipments; i++)
            {
                int cargoWeight = int.Parse(Console.ReadLine());
                totalWeight += cargoWeight;

                if (cargoWeight <= 3) cargoBus += cargoWeight;
                else if (cargoWeight <= 11) cargoTruck += cargoWeight;
                else cargoTrain += cargoWeight;
            }
            totalWeight = cargoBus + cargoTruck + cargoTrain;
            averagePrice = ((cargoBus*busCargoPriceTon) + (cargoTruck * truckCargoPriceTon) + (cargoTrain*trainCargoPriceTon)) / totalWeight;

            Console.WriteLine("{0:f2}", averagePrice);
            Console.WriteLine("{0:f2}%", ((cargoBus / totalWeight) * 100));
            Console.WriteLine("{0:f2}%", ((cargoTruck / totalWeight) * 100));
            Console.WriteLine("{0:f2}%", ((cargoTrain / totalWeight) * 100));
        }
    }
}
