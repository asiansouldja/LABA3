using System;
using System.IO;

namespace OOP_LABA3._2
{
   public class Program
    {
        
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("Q:\\DISC D\\ооп лаби\\laba3\\myText.txt");
            string line = f.ReadLine();
            string line2 = f.ReadLine();
            string line3 = f.ReadLine();

            f.Close();

            Console.WriteLine("Enter word");
            string word = Console.ReadLine();

            if (line.Contains(word))
            {
                Console.WriteLine(line);
            }
            if (line2.Contains(word))
            {
                Console.WriteLine(line2);
            }
            if (line3.Contains(word))
            {
                Console.WriteLine(line3);
            }










        }
    }
}
