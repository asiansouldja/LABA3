using System;

namespace OOP_LABA2
{
    class Program
    {

        static int isNum(string x)
        {
            int count = 0;
            foreach (char ch in x)
                if (Char.IsDigit(ch))
                    count++;
            return count;
        }
        static string reverse(string word) {
            char[] sReverse = word.ToCharArray();
            Array.Reverse(sReverse);
            word = new string(sReverse);
            return word;

        }
        
        
      
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте text");
            string x = Console.ReadLine();
            int nums = isNum(x);
            Console.WriteLine("К-сть чисел:" + nums);
            //*********************************

            Console.WriteLine("************");
            Console.WriteLine("Введть слово");
            string word = Console.ReadLine();
            string revWord = reverse(word);
            Console.WriteLine("Reversion:" + revWord);
             
           
           

            
            
            
           
            
            
        }
    }
}
