using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayAndLists
{
    internal class Program
    {

        static List<double> grades = new List<double>();

        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("======== Students Grades ========");
            Console.WriteLine("=================================");
            Console.Write("Please enter the number of students in your class: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            AddGrades(numberOfStudents);
            ShowGrades();
        }

        static void AddGrades(int numberOfStudents)
        {
            for (int i = 1; i <= numberOfStudents; i++)
            {
                Console.Write("Enter the grade for the student {0}: ", i);
                grades.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        static void ShowGrades()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Class average: {0}", grades.Average());
            Console.WriteLine("Class max: {0}", grades.Max());
            Console.WriteLine("Class min: {0}", grades.Min());
            Console.WriteLine("---------------------");

            grades.Sort();
            foreach (double grade in grades)
            {
                Console.WriteLine($"{grade}");
            }
        }
    }
}
