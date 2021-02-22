using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace øvelse_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("what is your weight in Pounds? ");
                decimal weight = Convert.ToDecimal(Console.ReadLine());
                Console.Write("what is your height in inches? ");
                decimal Height = Convert.ToDecimal(Console.ReadLine());
            
            var bmi = (weight / (Height * Height)) * 703;

            Console.WriteLine(" your BMI is {0}.", bmi);
            if (bmi < 18.5M)
            {
                Console.WriteLine("You are underweight. You should see your doctor.");
            }
            else if (bmi > 25m)
            {
                Console.WriteLine("You are overweight. You should see your doctor.");

            }
            else
            {
                Console.WriteLine("You are within the ideal weight range.");
            }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("you can only use numbers");
            }
            Console.ReadLine();

        }
    }
}
