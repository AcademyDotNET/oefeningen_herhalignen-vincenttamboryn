using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int getal;
            int poging = 0;
            int aantalPogingen = 0;
            string pogingString;
            bool gevonden = false;
            int ondergrensBegin = 0;
            int bovengrensBegin = 100;
            int ondergrens = ondergrensBegin;
            int bovengrens = bovengrensBegin;

            getal = rand.Next(ondergrensBegin, bovengrensBegin);
            double perfectguess = Math.Ceiling(Math.Log2(bovengrensBegin - ondergrensBegin));

            while (!gevonden && (aantalPogingen <= perfectguess))
            {
                aantalPogingen++;
                Console.WriteLine($"Geef een getal tussen {ondergrens} en {bovengrens}");
                pogingString = Console.ReadLine();
                poging = int.Parse(pogingString);
                if (poging <= ondergrens || poging >= bovengrens)
                {
                    Console.WriteLine("Enkel intelligente gokken toegestaan!!");
                }
                else
                {
                    if (getal > poging)
                    {
                        if (poging > ondergrens)
                        {
                            ondergrens = poging;
                        }
                        Console.WriteLine($"Het gezochte getal is groter, probeer opnieuw. We zoeken nu een getal tussen {ondergrens} en {bovengrens}");
                    }
                    else if (getal < poging)
                    {
                        if (poging < bovengrens)
                        {
                            bovengrens = poging;
                        }
                        Console.WriteLine($"Het gezochte getal is kleiner, probeer opnieuw. We zoeken nu een getal tussen {ondergrens} en {bovengrens}");
                    }
                    else
                        gevonden = true;
                }
            }
            if (gevonden)
            {
                Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
            }
            else
            {
                Console.WriteLine($"Je had het getal al kunnen raden. volgende keer wat beter gokken! het was {getal} btw");
            }
        }
    }
}
