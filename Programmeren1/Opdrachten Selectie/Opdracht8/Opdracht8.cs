using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht8
{
    class Opdracht8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            Console.Write("Enter how old the machine is in years): ");
            int yearsOld = int.Parse(Console.ReadLine());

            Console.Write("Enter number of failures: ");
            int failures = int.Parse(Console.ReadLine());

            int yearlyFailures = failures / yearsOld;

            Console.WriteLine();

            if(workingHours > 10000 || yearsOld >= 7 || yearlyFailures > 25)
                Console.WriteLine("Machine needs to be replaced");
            else
                Console.WriteLine("Machine does not need replacement");

            Console.ReadKey();
        }
    }
}
