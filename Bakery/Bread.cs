using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bakery
{
    class Bread
    {
        public string type;
        public double price;
        protected int fluor, water, salt, yeast;
        protected int cookingTime, restingTime, fermentTime, cookingTemperature;
        string[] ingredientes = new string[] { "Fluor", "Water", "Salt", "Yeast" };

        public virtual void mixingIngredients(int cantIngredients)
        {
            Console.WriteLine("Mixing " + ingredientes[0] + " " + (cantIngredients * fluor) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[1] + " " + (cantIngredients * water) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[2] + " " + (cantIngredients * salt) + " grams.");
            Console.WriteLine("Mixing " + ingredientes[3] + " " + (cantIngredients * yeast) + " grams.");
        }

            public void cutTheDough(int count)
        {
            if (count > 1)
            {
                Console.WriteLine("Cutting the Dough.");
            }
            else
                Console.WriteLine("No need to cut the Dough.");
        }

        public void LetTheDoughtRest()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Dough resting for {restingTime} mins.");
        }

        public void shapeTheDough()
        {

        }

        public void letTheDoughFerment()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Dough resting for {fermentTime} mins.");
        }

        public void cook()
        {
            Console.WriteLine($"Cooking {cookingTime} minutes in {cookingTemperature} degrees.");
        }

        public string Type { get { return type; } }
        public double Price { get { return price; } }
        public int Fluor { get { return fluor; } }
        public int Water { get { return water; } }
        public int Salt { get { return salt; } }
        public int Yeast { get { return yeast; } }
        public int RestingTime { get { return restingTime; } }
        public int FermentTime { get { return fermentTime; } }
        public int CookingTime { get { return cookingTime; } }
        public int CookingTemperature { get { return cookingTemperature; } }
    }
}
