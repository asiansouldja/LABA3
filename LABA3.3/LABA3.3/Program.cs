using System;
using System.IO;

namespace LABA3._3
{
    class Program
    {
        static string remSkob(string str)
        {
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '(')
                {
                    int k = i + 1;
                    while (arr[k] != ')')
                    {
                        arr[k] = '\0';
                        k++;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != '\0')
                {
                    result += arr[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("Q:\\DISC D\\ооп лаби\\laba3\\input.txt");
            
            string str = f.ReadLine();
            f.Close();
            Console.WriteLine("Text from input.txt:" + str);

            string final = remSkob(str);
            Console.WriteLine(final);

            using (StreamWriter fg = new StreamWriter("Q:\\DISC D\\ооп лаби\\laba3\\output.txt", true))
            {
                fg.Write(final);
                fg.Close();
                
            }
            


        }
    }
}
