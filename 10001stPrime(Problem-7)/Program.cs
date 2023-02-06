using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            int sayi = 0;
            long sayi2 = 600;

            for (int i = 0; i < 10001; i++)
            {
                sayi++;

                if (sayi == 2 || sayi == 3 || sayi == 5 || sayi == 7 || sayi == 11)
                {
                    //Console.WriteLine(sayi);
                    array.Add(sayi);
                }

                else if (sayi % 2 ==0 || sayi % 3 == 0 || sayi % 5 == 0 || sayi % 7 == 0 || sayi % 11 == 0 || sayi == 1 || sayi % 12 == 0 || sayi % 13 == 0 || sayi % 17 == 0 || sayi % 23 == 0)
                {
                    continue;
                }

                else
                {
                    //Console.WriteLine(sayi);
                    array.Add(sayi);
                }
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

          
        }
    }
}