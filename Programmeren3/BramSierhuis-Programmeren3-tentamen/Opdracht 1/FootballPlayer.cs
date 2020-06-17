using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3opgaven
{
    public class FootballPlayer
    {
        protected string name;
        protected int age;

        public FootballPlayer(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual int CalculateTransferValue()
        {
            return (27 - age) * 2;
        }

        public override string ToString()
        {
            return name + " (" + age + "), transfervalue: " + CalculateTransferValue() + "m";
        }
    }
}
