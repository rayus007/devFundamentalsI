using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery
{
    class Order
    {
        private string orderNumber;
        string breadType;
        int breadQuantity;
        double price;

        public Order(string orderNumber, string breadType, int breadQuantity, double price) 
        {
            this.orderNumber = orderNumber;
            this.breadType = breadType;
            this.breadQuantity = breadQuantity;
            this.price = price;
        }


        public string OrderNumber { get { return orderNumber; } }
        public string BreadType { get { return breadType; } }
        public int BreadQuantity { get { return breadQuantity; } }
        public double Price { get { return price; } }
    }
}
