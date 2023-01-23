

using System;

namespace ayseNur // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = 0;

            while (sayi < 10)
            {
                sayi++;
                if (sayi == 7) continue;
                Console.WriteLine(sayi);
            }

            Console.ReadLine();


        }
    }
}

