﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Boekhandel
{
    public abstract class Item
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalPrice 
        {
            get 
            {
                return Price;
            } 
        }

        public Item(string title, double price)
        {
            Title = title;
            Price = price;
            Count++;
        }

        ~Item

        public virtual void Print() { }
    }
}