using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery
{
    class Menu
    {
        protected List<Office> oficinas;
        private static double _finalPrice;
        private static int _finalOrders;

        public void getMainMenu()
        {
            if (oficinas == null) { createOffices(); }
                Console.WriteLine("BAKERY Fresh Bread ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Select an option from the menu:\n");
                Console.WriteLine("0. Total Orders");
                getOffices(oficinas);
                try{
                int office = int.Parse(Console.ReadLine());
                if (office == 0)
                {
                    getAllOrders();
                }

                else if(office > 0 && office <= oficinas.Count)
                {
                    ordersPrompt(oficinas[office - 1]);
                }
                else
                {
                    Console.WriteLine("Value not recognized.\n");
                    getMainMenu();
                }
                }
                catch
                {
                    Console.WriteLine("Value not recognized!!!!.\n");
                    getMainMenu();
                }
        }

        public List<Office> createOffices()
        {
            PastryChef cheffcito = new PastryChef("Chefcito");
            Office mainOffice = new Office("Main Office", cheffcito, 150);
            mainOffice.addBread(new Baguette());
            mainOffice.addBread(new WhiteBread());
            mainOffice.addBread(new MilkBread());
            addOffice(mainOffice);

            // Agregando siguiente oficina
            PastryChef cheffcito2 = new PastryChef("Chefcito2");
            Office secondaryOffice = new Office("Secondary Office", cheffcito2, 100);
            secondaryOffice.addBread(new Baguette());
            secondaryOffice.addBread(new WhiteBread());
            secondaryOffice.addBread(new HamburguerBun());
            addOffice(secondaryOffice);

            // Agregando ultima oficina
            /*PastryChef cheffcito3 = new PastryChef("Chefcito3");
            Office lastOffice = new Office("Third Office", cheffcito3, 200);
            lastOffice.addBread(new Baguette());
            lastOffice.addBread(new WhiteBread());
            lastOffice.addBread(new HamburguerBun());
            lastOffice.addBread(new MilkBread());
            addOffice(lastOffice);*/

            return oficinas;
        }

        public void addOffice(Office offi)
        {
            if (oficinas == null)
            {
                oficinas = new List<Office>();
                oficinas.Add(offi);
            }
            else oficinas.Add(offi);
        }

        public void getOffices(List<Office> listilla)
        {
                foreach (Office of in listilla)
            {
                Console.WriteLine((listilla.IndexOf(of)+1) + ". "+ of.Name);
            }
        }

        public void ordersPrompt(Office office)
        {
            Console.WriteLine("\n0. Go back to Main Menu.");
            Console.WriteLine("1. Add Order");
            if (office.Orders != null)
            {
                Console.WriteLine("2. Prepare all the Orders.");
            }

            try {
                int valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                {
                    getMainMenu();
                }
                else if (valor == 1)
                {
                    getBreadTypes(office);
                }
                else if (valor == 2)
                {
                    prepareOrders(office);
                }
                else
                {
                    Console.WriteLine("Value not recognized.\n");
                    ordersPrompt(office);
                }
            }
            catch
            {
                Console.WriteLine("Value not recognized.\n");
                ordersPrompt(office);
            }

        }

        public void getBreadTypes(Office myOffice)
        {
            Console.WriteLine("\nSelect a bread to continue or press 0 to go to previous prompt.");
            for (int i = 0; i < myOffice.Breads.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + myOffice.Breads[i].Type);
            }

            try
            {
                int breadsOption = int.Parse(Console.ReadLine());

                if (breadsOption == 0)
                {
                    ordersPrompt(myOffice);
                }

                else if (breadsOption>0 && breadsOption <= myOffice.Breads.Count) {
                    breadChoose(myOffice, breadsOption - 1);
                }
                else
                {
                    Console.WriteLine("Value not recognized.\n");
                    getBreadTypes(myOffice);
                }
            }
            catch
            {
                Console.WriteLine("Value not recognized.\n");
                getBreadTypes(myOffice);
            }
        }

        public void confirmOrder(Office myOffice, string type, int qty, double precio)
        {
            Console.WriteLine($"The price for {qty} breads {type} is: {precio} $us");
            Console.WriteLine("Confirm order?  Y/N ");
            try
            {
                string leerConsola = Console.ReadLine();
                if (leerConsola == "Y")
                {
                    Order myOrder = new Order("001", type, qty, precio);
                    myOffice.addOrder(myOrder);
                    _finalOrders++;
                    _finalPrice += precio;
                    Console.WriteLine("\nOrder added.\n");
                    getBreadTypes(myOffice);

                }
                else if (leerConsola == "N")
                {
                    Console.WriteLine("Going to previous prompt");
                    getBreadTypes(myOffice);
                }
                else
                {
                    Console.WriteLine("Value not recognized.\n");
                    confirmOrder(myOffice, type, qty, precio);
                }
            }
            catch
            {
                Console.WriteLine("Value not recognized.\n");
                confirmOrder(myOffice, type, qty, precio);
            }
        }

        public double calculatePrice(Bread bread, int qty)
        {
            return bread.Price * qty;
        }

        public void prepareOrders(Office myOffice)
        {
            foreach (Order orders in myOffice.Orders)
            {
                if (orders.BreadType == "Baguette")
                {
                    myOffice.Chef.prepareBaguette(orders.BreadQuantity);
                }
                if (orders.BreadType == "White Bread")
                {
                    myOffice.Chef.prepareWhiteBread(orders.BreadQuantity);
                }
                if (orders.BreadType == "Milk Bread")
                {
                    myOffice.Chef.prepareMilkBread(orders.BreadQuantity);
                }
                if (orders.BreadType == "Hamburguer Bun")
                {
                    myOffice.Chef.prepareHamgurguesBun(orders.BreadQuantity);
                }
            }
            Console.WriteLine("/////////////// Orders completed. ///////////////\n");
            myOffice.Orders = null;
            getMainMenu();
        }

        public int validateMaximumCapacity(Office myOffice)
        {
            int capacidad = myOffice.Capacity;
            if (myOffice.Orders == null)
            {
                return capacidad;
            }
            else
            {
                foreach (Order orders in myOffice.Orders)
                {
                    capacidad -= orders.BreadQuantity;
                }
                return capacidad;
            }
        }

        public void breadChoose(Office myOffice, int breadOption) {
            
            Console.WriteLine("Type a bread quantity to calculate price.");
            try
            {
                int qty = int.Parse(Console.ReadLine());
                if (qty <= validateMaximumCapacity(myOffice))
                {
                    double precio = calculatePrice(myOffice.Breads[breadOption], qty);
                    confirmOrder(myOffice, myOffice.Breads[breadOption].Type, qty, precio);
                }
                else
                {
                    Console.WriteLine("You only can place " + validateMaximumCapacity(myOffice) + " breads to accomplish " + myOffice.Name + " capacity.\n");
                    breadChoose(myOffice, breadOption);
                }
            }
            catch
            {
                Console.WriteLine("Value not recognized.\n");
                breadChoose(myOffice, breadOption);
            }

        }

        public void getAllOrders()
        {
            Console.WriteLine($"There was a total of {_finalOrders} Orders with an earned of {_finalPrice} $us.\n");
            Console.WriteLine("Press any Key to go back to main menu. \n");
            if (Console.ReadKey() != null)
            {
                getMainMenu();
            }
            else
                Console.WriteLine("Value not recognized");
        }
    }
}
