using System;
using System.Text;

namespace PrimitiveTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder header = new StringBuilder();

            header.Append('-', 32)
                .AppendLine()
                .Append("-- Body Mass Index Calculator --")
                .AppendLine()
                .Append('-', 32);

            Console.WriteLine(header);
            Console.Write("Please enter your weight in kg: ");
            string weight = Console.ReadLine();
            Console.Write("Please enter your height in mts: ");
            string height = Console.ReadLine();

            double bodyMassIndex = 0;

            try
            {
                bodyMassIndex = Convert.ToDouble(weight) / (Convert.ToDouble(height) * Convert.ToDouble(height));
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (bodyMassIndex > 0)
            {
                string category;
                if (bodyMassIndex > 30)
                {
                    category = "you have Obesity";
                }
                else if (bodyMassIndex > 25)
                {
                    category = "your Overweight";
                }
                else if (bodyMassIndex > 18.5)
                {
                    category = "your Normal";
                }
                else
                {
                    category = "your Underweight";
                }
                Console.WriteLine("Your BMI is: {0}, and {1}", Math.Round(bodyMassIndex, 2), category);
            }

        }
    }
}
