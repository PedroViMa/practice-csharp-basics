using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date;
            Console.WriteLine("=======================");
            Console.WriteLine("======== Dates ========");
            Console.WriteLine("=======================");
            Console.Write("Please enter the first date (MM/DD/YYYY): ");
            date = Console.ReadLine();
            DateTime startDate = Convert.ToDateTime(date);
            Console.Write("Please enter the second date (MM/DD/YYYY): ");
            date = Console.ReadLine();
            DateTime endDate = Convert.ToDateTime(date);

            int days = (startDate - endDate).Days;

            Console.WriteLine();
            Console.WriteLine($"There are {Math.Abs(days)} days between {startDate.ToShortDateString()} and {endDate.ToShortDateString()}.");
        }
    }
}
