using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = File.ReadAllLines("C:\\Users\\pvillarrealmartinez\\" +
                "Documents\\NET\\repos\\Exercise1\\Files\\Files\\Names.txt");
            var namesSorted = names.ToList();
            namesSorted.Sort();

            string path = "C:\\Users\\pvillarrealmartinez\\" +
                "Documents\\NET\\repos\\Exercise1\\Files\\Files\\NamesSorted.txt";

            StringBuilder sbNames = new StringBuilder();
            foreach (string name in namesSorted)
            {
                sbNames.AppendLine(name);
            }

            File.WriteAllText(path, sbNames.ToString());
        }
    }
}
