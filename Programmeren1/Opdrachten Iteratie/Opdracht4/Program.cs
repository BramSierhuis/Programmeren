using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 20;

            int x = 1;
            int y = 1;
            int z;

            Console.Write("{0}, {1}", x, y);

            for (int i = 2; i < length; i++)
            {
                z = x + y;
                x = y;
                y = z;

                Console.Write(", " + z);
            }

            Console.ReadKey();
        }
    }
}
