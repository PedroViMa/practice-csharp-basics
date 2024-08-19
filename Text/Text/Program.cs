using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string paragraph;

            do
            {
                Console.WriteLine("Please enter your text (press Enter twice to finish):");
                paragraph = Console.ReadLine();

                if(!string.IsNullOrWhiteSpace(paragraph))
                {
                    sb.AppendLine(paragraph);
                }
                else
                {
                    break;
                }
            } while (true);

            string text = sb.ToString();
            int countOfWords = -1;

            foreach (string line in text.Split('\n'))
            {
                countOfWords += line.Split(' ').Length;
            }

            int countOfSentences = text.Split(new char[]{'.', '?', '!'}).Length - 1;
            int countOfParagraphs = text.Split('\n').Length - 1;

            Console.WriteLine($"# of words: {countOfWords}");
            Console.WriteLine($"# of sentences: {countOfSentences}");
            Console.WriteLine($"# of paragraphs: {countOfParagraphs}");
        }
    }
}
