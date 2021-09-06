using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery
{
    class Office
    {

        private string name;
        private int capacity;
        private List<Bread> breads;
        private List<Order> orders;
        private PastryChef chef;

        public Office(string name, PastryChef chef, int capacity)
        {
            this.name = name;
            this.chef = chef;
            this.capacity = capacity;
        }

        public void addBread(Bread bread)
        {
            if (breads == null)
            {
                breads = new List<Bread>();
            }
            breads.Add(bread);
        }
        public void addOrder(Order order)
        {
            if (orders == null)
            {
                orders = new List<Order>();
            }
            orders.Add(order);
        }


        public string Name { get { return name; } }
        public int Capacity { get { return capacity; } }
        public List<Bread> Breads { get { return breads; } }
        public PastryChef Chef { get { return chef; } }
        public List<Order> Orders { get { return orders; } set { orders = value; } }

    }

}
