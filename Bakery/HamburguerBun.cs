using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery
{
    class HamburguerBun : Bread
    {
        protected int sugar, milk, butter, egg, sweetPotato, sesameSeed, gilding;
        protected string[] ingredientes = new string[] {"Sugar", "Milk", "Butter", "Egg", "Sweet Potato" };

        public HamburguerBun()
        {
            type = "Hamburguer Bun";
            price = 1.0;
            fluor = 100;
            water = 25;
            salt = 2;
            yeast = 4;
            sugar = 6;
            milk = 5;
            butter = 6;
            egg = 10;
            sweetPotato = 25;
            sesameSeed = 10;
            gilding = 5;
            restingTime = 30; // 10 mins
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
            Console.WriteLine("Mixing " + ingredientes[4] + " " + (cantIngredients * sweetPotato) + " grams.");
        }

        public void AddSesameAndGilding()
        {
            Console.WriteLine("Placing the Sesame seeds and Gilding on the top of the Dough.");
        }

        public int Sugar { get { return sugar; } }
        public int Milk { get { return milk; } }
        public int Butter { get { return butter; } }
        public int Egg { get { return egg; } }
        public int SweetPotato { get { return sweetPotato; } }
        public int SesameSeed { get { return sesameSeed; } }
        public int Gilding { get { return gilding; } }
    }
}
