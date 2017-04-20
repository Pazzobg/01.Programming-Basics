using System;

namespace _08.FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine().ToLower();
            double priceHrizantema = 0;
            double priceRose = 0;
            double priceTulip = 0;

            if (season == "spring" || season == "summer")
            {
                priceHrizantema += 2;
                priceRose += 4.10;
                priceTulip += 2.50;
            }
            else if (season == "autumn" || season == "winter")
            {
                priceHrizantema += 3.75;
                priceRose += 4.50;
                priceTulip += 4.15;
            }
            double bouquet = (hrizantemi * priceHrizantema) + (roses * priceRose) + (tulips * priceTulip);
            if (holiday == "y") bouquet += (bouquet * 0.15);
            if (season == "spring" && tulips > 7) bouquet -= (bouquet * 0.05);
            if (season == "winter" && roses >= 10) bouquet -= (bouquet * 0.10);
            if ((hrizantemi + roses + tulips) > 20) bouquet -= (bouquet * 0.20);

            Console.WriteLine("{0:f2}", (bouquet + 2));
        }
    }
}
