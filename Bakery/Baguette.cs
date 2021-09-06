using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery
{
    class Baguette : Bread
    {
        public Baguette()
        {
            type = "Baguette";
            price = 2.0;
            fluor = 280;
            water = 210;
            salt = 10;
            yeast = 5;
            restingTime = 30; // 30 mins
            fermentTime = 720; // 1 day
            cookingTime = 15; // 15 mins
            cookingTemperature = 270; //270 degrees      
        }

        public void foldTheDough()
        {
            Console.WriteLine("Folding the Dough.");
            fluor = 25;
        }
    }
}
