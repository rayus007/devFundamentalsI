using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery
{
    class WhiteBread : Bread
    {
        protected int sugar, milk, butter;
        protected string[] ingredientes = new string[] { "Sugar", "Milk", "Butter" };

        public WhiteBread()
        {
            type = "White Bread";
            price = 2.5;
            fluor = 1000;
            water = 280;
            salt = 20;
            yeast = 20;
            sugar = 80;
            milk = 60;
            butter = 100;
            restingTime = 60; //1Hrs.
            fermentTime = 240; //4Hrs.
            cookingTime = 15; // 15 mins
            cookingTemperature = 180; //180 degrees                   
        }

        public override void mixingIngredients(int cantIngredients)
        {
            base.mixingIngredients(cantIngredients);
            Console.WriteLine("Mixing " + ingredientes[0] + " " + (cantIngredients * sugar) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[1] + " " + (cantIngredients * milk) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[2] + " " + (cantIngredients * butter) + " grams.");
        }

        public int Sugar { get { return sugar; } }
        public int Milk { get { return milk; } }
        public int Butter { get { return butter; } }
    }
}
