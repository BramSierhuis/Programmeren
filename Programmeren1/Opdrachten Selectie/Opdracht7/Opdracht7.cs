using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7
{
    class Opdracht7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight (kg): ");
            int weight = int.Parse(Console.ReadLine());

            Console.Write("Enter length (cm): ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            Console.WriteLine();

            double bmi = CalculateBMI(weight, length);

            if(gender == "male")
            {
                double healthyWeightMin = 20 * ((length / 100.0) * (length / 100.0));
                double healthyWeightMax = 25 * ((length / 100.0) * (length / 100.0));

                Console.WriteLine("BMI: {0}", bmi.ToString(".0", CultureInfo.InvariantCulture));
                Console.WriteLine("Normal BMI values (min..max): 20..25");
                Console.WriteLine("Healthy weight range (min..max): {0}..{1}", 
                    healthyWeightMin.ToString(".0", CultureInfo.InvariantCulture), 
                    healthyWeightMax.ToString(".0", CultureInfo.InvariantCulture));
            } else if(gender == "female")
            {
                double healthyWeightMin = 19 * ((length / 100.0) * (length / 100.0));
                double healthyWeightMax = 24 * ((length / 100.0) * (length / 100.0));

                Console.WriteLine("BMI: {0}", bmi.ToString(".0", CultureInfo.InvariantCulture));
                Console.WriteLine("Normal BMI values (min..max): 19..24");
                Console.WriteLine("Healthy weight range (min..max): {0}..{1}", 
                    healthyWeightMin.ToString(".0", CultureInfo.InvariantCulture), 
                    healthyWeightMax.ToString(".0", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Sorry mate, no gender neutrals here!");
            }

            Console.ReadKey();
        }

        static double CalculateBMI(double weight, double length)
        {
            double bmi = weight / ((length / 100.0) * (length / 100.0));
            return bmi;
        }
    }
}
