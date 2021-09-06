using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery
{
    class MilkBread : Bread
    {
        protected int sugar, milk, butter, egg, honey, lemonZest, vanillaEssence;
        string[] ingredientes = new string[] { "Sugar", "Milk", "Butter", "Egg", "Honey", "Lemon Zest", "Vanilla Essence" };

        public MilkBread()
        {
            type = "Milk Bread";
            price = 1.5;
            fluor = 55;
            water = 25;
            salt = 1;
            yeast = 3;
            sugar = 6;
            milk = 10;
            butter = 10;
            egg = 10;
            honey = 2;
            lemonZest = 1;
            vanillaEssence = 1;
            restingTime = 10; // 10 mins
            fermentTime = 240; // 4 hours
            cookingTime = 15; // 15 mins
            cookingTemperature = 180; //180 degrees                   
        }

        public override void mixingIngredients(int cantIngredients)
        {
            base.mixingIngredients(cantIngredients);
            Console.WriteLine("Mixing " + ingredientes[0] + " " + (cantIngredients * sugar) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[1] + " " + (cantIngredients * milk) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[2] + " " + (cantIngredients * butter) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[3] + " " + (cantIngredients * egg) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[4] + " " + (cantIngredients * honey) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[5] + " " + (cantIngredients * lemonZest) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[6] + " " + (cantIngredients * vanillaEssence) + " grams.");
        }

        public int Sugar { get { return sugar; } }
        public int Milk { get { return milk; } }
        public int Butter { get { return butter; } }
        public int Egg { get { return egg; } }
        public int Honey { get { return honey; } }
        public int LemonZest { get { return lemonZest; } }
        public int VanillaEssence { get { return vanillaEssence; } }
    }
}
