using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public abstract class BigDataLoader
    {
        public void StartETL()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[ETL-proces started]");
            Console.ResetColor();

            Extract();
            Transform();
            Load();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[ETL-proces stopped]");
            Console.ResetColor();
        }

        public abstract void Extract();

        public abstract void Transform();

        public abstract void Load();
    }
}
