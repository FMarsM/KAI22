using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAI2
{
    class Program
    {
        static void Spl1()
        {
            System.Console.WriteLine("Pascal Triangle Program");
            System.Console.Write("Enter the number of rows: ");
            string input = System.Console.ReadLine();

            int n = Convert.ToInt32(input);


            for (int y = 0; y < n; y++)
            {
                int c = 1;
                for (int q = 0; q < n - y; q++)
                {
                    System.Console.Write("   ");
                }

                for (int x = 0; x <= y; x++)
                {
                    System.Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
        static void Spl()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            char[] s = str.ToCharArray();
            Console.WriteLine("Введите символ, который хотите удалить из строки");
            char symb = Convert.ToChar(Console.ReadLine());
            for (int i=0;i<s.Length;i++)
            {
                if (s[i]!=symb)
                {
                    Console.Write(s[i]);
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Spl();
            //int rank=Convert.ToInt32(Console.ReadLine());
            //TrPasc(rank);
            Spl1();
            Console.ReadKey();

        }
    }
}
