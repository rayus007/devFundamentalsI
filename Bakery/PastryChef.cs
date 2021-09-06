using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bakery
{
    class PastryChef
    {
        string name;

        public PastryChef(string name) {
            this.name = name;
        }
        public void prepareBaguette(int cantidad)
        {
            Console.WriteLine("***************Preparing Baguette Bread***************");
            Thread.Sleep(1000);
            Baguette myBaguette = new Baguette();
            myBaguette.mixingIngredients(cantidad);
            myBaguette.LetTheDoughtRest();
            myBaguette.foldTheDough();
            myBaguette.LetTheDoughtRest();
            myBaguette.foldTheDough();
            myBaguette.LetTheDoughtRest();
            myBaguette.cutTheDough(cantidad);
            myBaguette.shapeTheDough();
            myBaguette.LetTheDoughtRest();
            myBaguette.cook();
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{cantidad} Baguettes Ready !!");
            Console.WriteLine("----------------------------");

        }

        public void prepareWhiteBread(int cantidad)
        {
            Console.WriteLine("***************Preparing White Bread***************");
            Thread.Sleep(1000);
            WhiteBread myWhiteBread = new WhiteBread();
            myWhiteBread.mixingIngredients(cantidad);
            myWhiteBread.cutTheDough(cantidad);
            myWhiteBread.letTheDoughFerment();
            myWhiteBread.shapeTheDough();
            myWhiteBread.LetTheDoughtRest();
            myWhiteBread.cook();
            Console.WriteLine("----------------------------");
            Console.WriteLine($" {cantidad} White Bread Ready !!");
            Console.WriteLine("----------------------------");
        }

        public void prepareMilkBread(int cantidad)
        {
            Console.WriteLine("***************Preparing Milk Bread***************");
            Thread.Sleep(1000);
            MilkBread myMilkBread = new MilkBread();
            myMilkBread.mixingIngredients(cantidad);
            myMilkBread.cutTheDough(cantidad);
            myMilkBread.LetTheDoughtRest();
            myMilkBread.shapeTheDough();
            myMilkBread.letTheDoughFerment();
            myMilkBread.cook();
            Console.WriteLine("----------------------------");
            Console.WriteLine($" {cantidad} Milk Bread Ready !!");
            Console.WriteLine("----------------------------");
        }

        public void prepareHamgurguesBun(int cantidad)
        {
            Console.WriteLine("***************Preparing Hamburguer Bun***************");
            Thread.Sleep(1000);
            HamburguerBun myHamburguerBun = new HamburguerBun();
            myHamburguerBun.mixingIngredients(cantidad);
            myHamburguerBun.cutTheDough(cantidad);
            myHamburguerBun.LetTheDoughtRest();
            myHamburguerBun.shapeTheDough();
            myHamburguerBun.letTheDoughFerment();
            myHamburguerBun.AddSesameAndGilding();
            myHamburguerBun.cook();
            Console.WriteLine("----------------------------");
            Console.WriteLine($" {cantidad} Hamburguer Buns Ready !!");
            Console.WriteLine("----------------------------");
        }
        public string Name { get { return name; } set { name = value; } }

    }
}
