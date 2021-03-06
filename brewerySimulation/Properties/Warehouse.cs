﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace brewerySimulation.Properties
{
    public class Warehouse
    {
        private int quantity; //ilosc dostepnych butelek

        public Warehouse(int qua)
        {
            quantity = qua;
        }
        public int HowManyBottles() => quantity;

        public void deliverBottle()
        {
            quantity = quantity - 1;
        }

        public void receiveBottle(int ilosc)
        {
            quantity = quantity + ilosc;
        }
    }
}
