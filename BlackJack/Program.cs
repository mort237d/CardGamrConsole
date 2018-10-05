using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameConsole;

namespace CardGameConsole
{
    class Program
    {
        private List<int> list = new List<int>();
        static void Main(string[] args)
        {
            UnoGame unoGame = new UnoGame();
        }

        private static void FindBiggestnumberInRandomArray()
        {
//Find største tal i random array
            int[] biggestArray = {10, 45, 12, 85, 10002, 5};
            int biggestInt = 0;

            for (int i = 0; i < biggestArray.Length; i++)
            {
                if (biggestInt < biggestArray[i])
                {
                    biggestInt = biggestArray[i];
                }
            }

            Console.WriteLine(biggestInt);
            //Console.WriteLine(biggest.Max());
        }

        private static void Fibbonachi()
        {
//Fibbonachi
            int[] a = new int[50];
            a[0] = 0;
            a[1] = 1;

            for (int i = 2; i < 50; i++)
            {
                a[i] = a[i - 2] + a[i - 1];
            }

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void WriteStringBaglaens()
        {
//String baglæns
            string str = "hej";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }

        private static void WriteArrayFromLasttoFirst()
        {
//Array baglæns
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = i;
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
